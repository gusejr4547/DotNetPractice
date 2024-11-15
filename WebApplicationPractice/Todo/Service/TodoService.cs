using WebApplicationPractice.Todo.DTO;
using WebApplicationPractice.Todo.Entity;
using WebApplicationPractice.Todo.Repository;

namespace WebApplicationPractice.Todo.Service
{
    public class TodoService
    {
        private readonly TodoRepository _todoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<TodoItemDTO.Response> createTodo(TodoItemDTO.Post todoDTO)
        {
            TodoItem todo = new TodoItem
            {
                Name = todoDTO.Name,
                IsComplete = todoDTO.IsComplete,
            };

            await _todoRepository.AddAsync(todo);

            return new TodoItemDTO.Response
            {
                Id = todo.Id,
                Name = todo.Name,
                IsComplete = todo.IsComplete,
            };
        }
    }
}
