﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Dealer : Player
    {
        private Deck m_deck = null;

        private rules.INewGameStrategy m_newGameRule;
        private rules.IHitStrategy m_hitRule;


        public Dealer(rules.RulesFactory a_rulesFactory)
        {
            m_newGameRule = a_rulesFactory.GetNewGameRule();
            m_hitRule = a_rulesFactory.GetHitRule();
        }

        public bool NewGame(Player a_player)
        {
            if (m_deck == null || IsGameOver())
            {
                m_deck = new Deck();
                ClearHand();
                a_player.ClearHand();
                return m_newGameRule.NewGame(m_deck, this, a_player);   
            }
            return false;
        }

        public bool Hit(Player a_player)
        {
            if (m_deck != null && a_player.CalcScore() < g_maxScore && !IsGameOver())
            {
                dealCardTo(a_player, true);

                return true;
            }
            return false;
        }
        
        public bool Stand(Player a_player)
        {
            if(m_deck != null)
            {
                ShowHand();

                while(m_hitRule.DoHit(this))
                {
                   
                    dealCardTo(this, true);
                }

                return true;
            }
            return false;
        }


        public bool IsGameOver()
        {
            if (m_deck != null && /*CalcScore() >= g_hitLimit*/ m_hitRule.DoHit(this) != true)
            {
                return true;
            }
            return false;
        }

        public void dealCardTo(Player a_to, bool a_doShow)
        {
            Card c = m_deck.GetCard();
            c.Show(a_doShow);
            a_to.DealCard(c);
            
        }
    }
}
