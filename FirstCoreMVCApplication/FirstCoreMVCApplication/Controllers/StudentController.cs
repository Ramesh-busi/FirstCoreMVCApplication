using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVCApplication.Models;
using FirstCoreMVCApplication.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstCoreMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Details()
        {
            //student basic details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            //Student Address

            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };

            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title= "Student Details Page",
                Header= "Student Details"

            };

            return View(studentDetailsViewModel);
            
        }
    }
}
