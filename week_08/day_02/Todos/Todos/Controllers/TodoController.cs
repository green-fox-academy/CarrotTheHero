﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todos.Entities;
using Todos.Models;
using Todos.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todos.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("/todo")]
        public IActionResult Index()
        {
            return View(TodoRepository.GetAll());
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetLast());
        }

        [Route("/add")]
        public IActionResult Add()
        {
            TodoRepository.AddTodo();
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.DeleteTodo(id);
            return RedirectToAction("Index");
        }
    }
}
