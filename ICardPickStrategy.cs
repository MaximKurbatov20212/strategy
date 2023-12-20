using Nsu.ColiseumProblem.Contracts.Cards;

namespace Nsu.ColiseumProblem.Contracts;

public interface ICardPickStrategy
{
    public int Pick(Card[] cards);
}
