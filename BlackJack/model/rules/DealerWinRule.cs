using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.model.rules
{
    class DealerWinRule : WinRule
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
            return dealer.CalcScore() >= player.CalcScore();
        }
    }
}
