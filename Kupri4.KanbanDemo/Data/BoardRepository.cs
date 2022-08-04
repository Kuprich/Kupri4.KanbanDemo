using Kupri4.KanbanDemo.Models;

namespace Kupri4.KanbanDemo.Data;

public static class BoardRepository
{
    private static Board _board = InitBoard();
    public static Board Board => _board;

    private static Board InitBoard()
    {

        List<Card> CardsList1 = Enumerable.Range(1, 5)
            .Select(i => new Card()
            {
                Title = $"Title{i}",
                Description = $"Lorem ipsum dolor sit amet{i}"
            })
            .ToList();
        List<Card> CardsList2 = Enumerable.Range(1, 5)
            .Select(i => new Card()
            {
                Title = $"Title{i + 10}",
                Description = $"Excepteur sint occaecat cupidatat{i + 10}"
            })
            .ToList();

        List<Card> CardList3 = new()
        { new Card() { Title = "example task", Description = "Completed Task 2000" } };

        List<Column> columns = new()
        {
            new Column() { Title = "Open", Cards = CardsList1 },
            new Column() { Title = "In Progress", Cards = CardsList2 },
            new Column() { Title = "Completed", Cards = CardList3 },
        };


        return new Board()
        {
            Title = "Some Board",
            Columns = columns
        };
    }
}
