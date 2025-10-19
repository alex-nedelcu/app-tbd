using AppTbd.Core.Models;

namespace AppTbd.Core.Usecases;

public interface IGetTodoItemsUsecase
{
    Task<IEnumerable<TodoItem>> GetAll();
}