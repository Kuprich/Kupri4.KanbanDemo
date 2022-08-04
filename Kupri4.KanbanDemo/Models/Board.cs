namespace Kupri4.KanbanDemo.Models;

public class Board
{
    public string Title { get; set; } = "Default Board";
    public List<Column> Columns { get; set; } = new List<Column>();
}
