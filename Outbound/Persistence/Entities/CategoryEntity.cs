namespace AppTbd.Outbound.Persistence.Entities;

public class CategoryEntity
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    // Relationships
    public ICollection<TodoItemEntity> TodoItems { get; set; }
}