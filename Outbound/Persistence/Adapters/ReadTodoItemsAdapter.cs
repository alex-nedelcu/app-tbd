using AppTbd.Core.Models;
using AppTbd.Core.Ports;
using AppTbd.Outbound.Persistence.Converters;
using Microsoft.EntityFrameworkCore;

namespace AppTbd.Outbound.Persistence.Adapters;

public class ReadTodoItemsAdapter : IReadTodoItemsPort
{
    private readonly AppTbdDbContext _context;

    public ReadTodoItemsAdapter(AppTbdDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TodoItem>> ReadAll()
    {
        var todoItemEntities = await _context.TodoItems.ToListAsync();

        return todoItemEntities.Select(TodoItemEntityConverter.Convert);
    }
}