using AppTbd.Core.Models;
using AppTbd.Inbound.Rest.Responses;

namespace AppTbd.Inbound.Rest.Converters;

public class TodoItemRestConverter
{
    public static TodoItemRest Convert(TodoItem todoItem)
    {
        return new TodoItemRest
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete,
        };
    }
}
