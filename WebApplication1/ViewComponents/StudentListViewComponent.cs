using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class StudentListViewComponent:ViewComponent
    {
        private SchoolDbContext _context;

        public StudentListViewComponent(SchoolDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke(string filter)
        {
            filter=HttpContext.Request.Query["filter"];
            return View(new StudentListViewModel
            {
                Students= _context.Students.Where(s=>s.Firstname.ToLower().Contains(filter)).ToList(),
            });
        }
    }
}
