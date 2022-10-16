namespace TodoDemo.Data
{
    public interface ISingletonRepo
    {
        IList<TodoItem> GetAll();
    }

    public class InMemoryRepo : ISingletonRepo
    {
        List<TodoItem> Items { get; set; }

        public InMemoryRepo()
        {
            Items = new List<TodoItem>
            {
                new TodoItem { Name = "Task1", Priority = 1, Status = TodoStatus.NotStarted },
                new TodoItem { Name = "Task2", Priority = 2, Status = TodoStatus.InProgress },
                new TodoItem { Name = "Task3", Priority = 3, Status = TodoStatus.Completed },
            };
        }

        #region crud

        public IList<TodoItem> GetAll()
        {
            return Items;
        }

        #endregion
    }

}
