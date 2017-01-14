using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private int g_hitLimit = 17;

        public bool DoHit(Player player)
        {
            var cardList = player.GetHand();
            int score = player.CalcScore();

            if (score == g_hitLimit)
            {
                foreach (var card in cardList)
                {
                    if (card.GetValue() == Card.Value.Ace)
                    {
                        return true;
                    }
                }
            }
            return score < g_hitLimit;
        }
    }
}
