using WebApplicationPractice.Todo.Entity;

namespace WebApplicationPractice.Todo.Repository
{
    public class TodoRepository
    {
        private readonly TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<TodoItem?> GetById(long id)
        {
            return await _context.Todos.FindAsync(id);
        }

        public async Task AddAsync(TodoItem todoItem)
        {
            _context.Todos.Add(todoItem);
            await _context.SaveChangesAsync();
        }
    }
}
