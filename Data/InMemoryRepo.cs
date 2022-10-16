using System.Collections.ObjectModel;

namespace TodoDemo.Data
{
    public interface ISingletonRepo
    {
        IList<TodoItem> GetAll();

        void InsertItem(TodoItem item);

        void UpdateItem(TodoItem item);

        void DeleteItem(string name);
    }

    public class TodoItemKeyed : KeyedCollection<string, TodoItem>
    {
        protected override string GetKeyForItem(TodoItem item)
        {
            return item.Name;
        }
    }

    public class InMemoryRepo : ISingletonRepo
    {
        TodoItemKeyed items;

        public InMemoryRepo()
        {
            items = new TodoItemKeyed
            {
                new TodoItem { Name = "Task1", Priority = 1, Status = TodoStatus.NotStarted },
                new TodoItem { Name = "Task2", Priority = 2, Status = TodoStatus.InProgress },
                new TodoItem { Name = "Task3", Priority = 3, Status = TodoStatus.Completed },
            };
        }

        #region crud

        public IList<TodoItem> GetAll()
        {
            return items;
        }

        public TodoItem GetItem(string name)
        {
            if (!items.Contains(name))
                throw new KeyNotFoundException($"Item with name {name} is not found");

            return items[name];
        }

        public int Count => items.Count;

        public void InsertItem(TodoItem item)
        {
            if (items.Contains(item.Name))
                throw new ArgumentException("Name must be unique");

            items.Add(item);
        }

        public void UpdateItem(TodoItem item)
        {
            // TODO : add locker
            //        delete is completed (front (once update successful) and back end)

            var localItem = GetItem(item.Name);

            localItem.Priority = item.Priority;
            localItem.Status = item.Status;
        }

        public void DeleteItem(string name)
        {
            var localItem = GetItem(name);

            items.Remove(localItem);
        }

        #endregion
    }

}
