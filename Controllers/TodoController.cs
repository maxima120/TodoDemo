using Microsoft.AspNetCore.Mvc;
using TodoDemo.Data;

namespace TodoDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly ILogger<TodoController> logger;
    private readonly ISingletonRepo repo;

    public TodoController(ILogger<TodoController> logger, ISingletonRepo repo)
    {
        this.repo = repo;
        this.logger = logger;
    }

    [HttpGet]
    public IEnumerable<TodoItem> GetAll()
    {
        return repo?.GetAll();
    }

    [HttpPost]
    public void InsertItem([FromBody] TodoItem item)
    {
        repo?.InsertItem(item);
    }

    [HttpPut]
    public void UpdateItem([FromBody] TodoItem item)
    {
        repo?.UpdateItem(item);
    }
    
    [HttpDelete]
    public void DeleteItem(string name)
    {
        repo?.DeleteItem(name);
    }
}
