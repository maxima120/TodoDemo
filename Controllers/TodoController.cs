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
    public IEnumerable<TodoItem> Get()
    {
        return repo?.GetAll();
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
