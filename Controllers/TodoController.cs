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
        return null;
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
