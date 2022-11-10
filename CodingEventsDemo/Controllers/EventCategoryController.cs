using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;

        public EventCategoryController(EventDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.title = "All Categories";
            List<EventCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new AddEventCategoryViewModel());
        }

        [HttpPost]
        public IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newCategory = new EventCategory(viewModel.Name);
                context.Categories.Add(newCategory);
                context.SaveChanges();
                return View("Index");
            }
            else
            {
                return View("Create");
            }
        }
    }
}
