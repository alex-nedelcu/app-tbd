using AppTbd.Core.Models;

namespace AppTbd.Core.Ports;

public interface IReadTodoItemsPort
{
    Task<IEnumerable<TodoItem>> ReadAll();
}