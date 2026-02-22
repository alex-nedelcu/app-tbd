using AppTbd.Core.Usecases;
using AppTbd.Inbound.Rest.Converters;
using AppTbd.Inbound.Rest.Responses;
using Microsoft.AspNetCore.Mvc;

namespace AppTbd.Inbound.Rest
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly IGetTodoItemsUsecase _getTodoItemsUsecase;

        public TodoItemsController(IGetTodoItemsUsecase getTodoItemsUsecase)
        {
            _getTodoItemsUsecase = getTodoItemsUsecase;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItemRest>>> GetTodoItems()
        {
            var todoItems = await _getTodoItemsUsecase.GetAll();

            return Ok(todoItems
                .Select(TodoItemRestConverter.Convert)
                .ToList());
        }
    }
}