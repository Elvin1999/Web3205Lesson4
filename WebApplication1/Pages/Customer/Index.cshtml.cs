using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly SchoolDbContext _context;

        public IndexModel(SchoolDbContext context)
        {
            _context = context;
        }
        public List<Student> Students { get; set; }
        public string Message { get; set; }
        public void OnGet(string search)
        {
            Students = string.IsNullOrEmpty(search)?
                _context.Students.ToList() : 
                _context.Students.Where(s=>s.Firstname.ToLower().Contains(search.ToLower())).ToList();
            Message = "Date is  " + DateTime.Now.ToLongDateString();
        }


        [BindProperty]
        public Student Student { get; set; }

        public IActionResult OnPost()
        {


            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }


    }
}
