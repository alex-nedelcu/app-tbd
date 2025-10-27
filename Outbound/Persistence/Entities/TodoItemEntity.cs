namespace AppTbd.Outbound.Persistence.Entities;

public class TodoItemEntity
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required bool IsComplete { get; set; }
    public DateTime? Deadline { get; set; }
}