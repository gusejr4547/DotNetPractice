namespace WebApplicationPractice.Todo.DTO
{
    public class TodoItemDTO
    {
        public class Post
        {
            public string? Name { get; set; }
            public bool IsComplete { get; set; }
        }

        public class Response
        {
            public long Id { get; set; }
            public string? Name { get; set; }
            public bool IsComplete { get; set; }
        }
    }
}
