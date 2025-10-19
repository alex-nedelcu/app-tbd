namespace AppTbd.Core.Models;

public class TodoItem
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required bool IsComplete { get; set; }
}