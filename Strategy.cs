using Nsu.ColiseumProblem.Contracts;
using Nsu.ColiseumProblem.Contracts.Cards;

namespace Nsu.ColiseumProblem.BestStrategy;

public class BestStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        if (cards.Length != 18) return 1;

        for (int x = 0; x < cards.Length; x += 1)
        {
            if (x % 2 == 0)
            {
                if (cards[x].Color == CardColor.Black) return x;
            }

            else
            {
                if (cards[x].Color == CardColor.Red) return x;
            }
        }

        return 1;
    }
}