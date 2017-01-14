using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.model.rules
{
    interface WinRule
    {
        bool IsWin(Player player, Player dealer);
    }
}
