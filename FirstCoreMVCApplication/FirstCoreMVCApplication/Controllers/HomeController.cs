using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVCApplication.Models;

namespace FirstCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository _repository = null;

        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Index()
        {
            
            return Json(new { Name = "Ramesh" , Department="IT", Salary=70000 });
        }

        public JsonResult  GetStudentDetails(int Id)
        {
            //TestStudentrepository repository = new TestStudentrepository();
            //Use the _repository to call the GetStudentById method 
            Student StudentDetails = _repository.GetStudentById(Id);
            return Json(StudentDetails);
        }

        public ViewResult Details()
        {
            //String string data
            //ViewData["Title"] = "Student Details page";
            //ViewData["Header"] = "Student details";
            ViewBag.Title = "Student Details page";
            ViewBag.Header= "Student details";
            Student student = new Student()
            {
                StudentId=101,
                Name="Ramesh",
                Branch="IT",
                Section="B",
                Gender="Male"
            };

           // ViewData["Student"] = student;
           //ViewBag.Student= student;
            return View(student);
            //return View("Test");
            //return View("/Views/Home/Test.cshtml");
        }
    }
}
