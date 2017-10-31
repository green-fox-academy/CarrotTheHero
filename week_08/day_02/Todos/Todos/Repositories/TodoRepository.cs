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
    }
}
