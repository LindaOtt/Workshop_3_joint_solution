using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.model.rules
{
    class PlayerWinRule : WinRule
    {
        int _maxScore = 21;

        public bool IsWin(Player player, Player dealer)
        {
            if (player.CalcScore() > _maxScore)
            {
                return true;
            }
            else if (dealer.CalcScore() > _maxScore)
            {
                return false;
            }

            return player.CalcScore() > player.CalcScore(); 
        }
    }
}
