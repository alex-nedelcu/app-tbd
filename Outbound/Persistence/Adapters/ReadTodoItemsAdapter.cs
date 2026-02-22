using AppTbd.Core.Models;
using AppTbd.Core.Ports;
using AppTbd.Outbound.Persistence.Converters;
using Microsoft.EntityFrameworkCore;

namespace AppTbd.Outbound.Persistence.Adapters;

public class ReadTodoItemsAdapter(AppTbdDbContext context) : IReadTodoItemsPort
{
    public async Task<IEnumerable<TodoItem>> ReadAll()
    {
        var todoItemEntities = await context.TodoItems.ToListAsync();

        return todoItemEntities.Select(TodoItemEntityConverter.Convert);
    }
}