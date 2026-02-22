using AppTbd.Core.Models;
using AppTbd.Outbound.Persistence.Entities;

namespace AppTbd.Outbound.Persistence.Converters;

public class TodoItemEntityConverter
{
    public static TodoItem Convert(TodoItemEntity todoItemEntity)
    {
        return new TodoItem
        {
            Id = todoItemEntity.Id,
            Name = todoItemEntity.Name,
            IsComplete = todoItemEntity.IsComplete,
        };
    }
}