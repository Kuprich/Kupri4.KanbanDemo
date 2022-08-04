using Kupri4.KanbanDemo.Models;

namespace Kupri4.KanbanDemo.Data;

public static class BoardRepository
{
    private static Board _board { get; set; } = InitBoard();
    public static Board Board => _board;

    private static Board InitBoard()
    {

        List<Card> CardsList1 = Enumerable.Range(1, 5)
            .Select(i => new Card()
            { 
                Title = $"Title{i}", 
                Description = $"Description{i}" 
            })
            .ToList();

        List<Card> CardsList2 = Enumerable.Range(1, 5)
            .Select(i => new Card()
            {
                Title = $"Title{i+10}",
                Description = $"Description{i+10}"
            })
            .ToList();

        List<Column> columns = new List<Column>()
        {
            new Column() { Title = "Open", Cards = CardsList1},
            new Column() { Title = "In Progress", Cards = CardsList2},
            new Column() { Title = "Completed", Cards = new List<Card>()},
        };

        
        return new Board()
        {
            Title = "Some Board",
            Columns = columns
        };
    }
}
