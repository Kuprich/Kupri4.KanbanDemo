namespace Kupri4.KanbanDemo.Models;

public class Column
{
    public string Title { get; set; } = "Default Title";
    public List<Card> Cards { get; set; } = new List<Card>();
}
