namespace TodoDemo;

public enum TodoStatus { NotStarted = 0, InProgress, Completed }
public class TodoItem
{
    public string Name { get; set; }

    public int Priority { get; set; }

    public TodoStatus Status { get; set; }
}
