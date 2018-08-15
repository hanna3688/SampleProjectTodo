using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using MyApplication1.Models;
using MyApplication1.Models.ViewModels;

namespace MyApplication1.Controllers
{
    public class ToDoController : Controller
    {
        private ApplicationDbContext _context;
        public ToDoController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ToDo
        public ActionResult Index()
        {
            var todos = _context.Todos.Include(t => t.Category).ToList();
            var todosView = new TodoViewModel
            {
                Todos = todos,
                Categories = _context.Categories.ToList()
            };
            return View(todosView);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}