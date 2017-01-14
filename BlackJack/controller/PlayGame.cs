using BlackJack.model.rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame : Observer
    {
        private model.Game m_game;
        private view.IView m_view;
        private bool _isWhoWin;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            m_game = a_game;
            m_view = a_view;
            a_game.AddObserver(this);
        }

        public bool choiceMode()
        {
            m_view.DisplayWelcomeMessage();

            int input = m_view.GetInput();

            if (m_view.PlayerWin(input))
            {
                _isWhoWin = true;
                return false;
            }
            else if (m_view.DealerWin(input))
            {
                _isWhoWin = false;
                return false;
            }

            return true;
        }

        public bool Play()
        {
            m_view.DisplayStart();

            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());

            if (m_game.IsGameOver())
            {
                 m_view.DisplayGameOver(m_game.IsDealerWinner(_isWhoWin));
            }

            int input = m_view.GetInput();

            if (m_view.WantToPlay(input))
            {
                m_game.NewGame();
            }
            else if (m_view.WantToHit(input))
            {
                m_game.Hit();
            }
            else if (m_view.WantToStand(input))
            {
                m_game.Stand();
            }
            else if (m_view.WantToQuit(input))
            {
                return false;
            }

            return true;
        }

        public void Update()
        {
            m_view.delay();
            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
        }
    }
}
