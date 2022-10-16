using Microsoft.AspNetCore.Mvc;

namespace TodoDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<TodoItem> Get()
    {
        return new List<TodoItem> { 
            new TodoItem { Name = "Task1", Priority = 1, Status = TodoStatus.NotStarted }, 
            new TodoItem { Name = "Task2", Priority = 2, Status = TodoStatus.InProgress }, 
            new TodoItem { Name = "Task3", Priority = 3, Status = TodoStatus.Completed },
        };
    }
    [HttpPut]
    public void Put()
    {
    }
    [HttpPost]
    public void Post()
    {
    }
    [HttpDelete]
    public void Delete()
    {
    }
}
