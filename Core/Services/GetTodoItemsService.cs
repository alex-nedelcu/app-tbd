using AppTbd.Core.Models;
using AppTbd.Core.Ports;
using AppTbd.Core.Usecases;

namespace AppTbd.Core.Services;

public class GetTodoItemsService : IGetTodoItemsUsecase
{
    private readonly IReadTodoItemsPort _readTodoItemsPort;

    public GetTodoItemsService(IReadTodoItemsPort readTodoItemsPort)
    {
        _readTodoItemsPort = readTodoItemsPort;
    }

    public async Task<IEnumerable<TodoItem>> GetAll()
    {
        var todoItems = await _readTodoItemsPort.ReadAll();

        return todoItems;
    }
}