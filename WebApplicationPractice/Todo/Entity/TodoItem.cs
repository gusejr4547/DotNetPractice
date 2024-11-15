namespace WebApplicationPractice.Todo.Entity
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        //public TodoItem(string name, bool isComplete = false) { 
        //    this.Name = name;
        //    this.IsComplete = isComplete;
        //}

    }
}
