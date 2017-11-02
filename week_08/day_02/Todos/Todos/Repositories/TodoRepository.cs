using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Entities;
using Todos.Models;

namespace Todos.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTodo()
        {
            var todo = new Todo()
            {
                Title = "Go Home",
                IsDone = true,
                IsUrgent = true
            };

            TodoContext.Todoes.Add(todo);
            TodoContext.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return TodoContext.Todoes.ToList();
        }

        public void DeleteTodo(int id)
        {
            Todo deletedTodo = TodoContext.Todoes.FirstOrDefault(x => x.Id == id);
            TodoContext.Todoes.Remove(deletedTodo);
            TodoContext.SaveChanges();
        }

        public void AddTodo(string title)
        {
            var todo = new Todo()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false
            };

            TodoContext.Todoes.Add(todo);
            TodoContext.SaveChanges();
        }
    }
}
