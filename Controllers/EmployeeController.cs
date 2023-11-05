﻿using Microsoft.AspNetCore.Mvc;
using Application1.Models;
using System.Text.Encodings.Web;

namespace Application1.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> _employees;
        public EmployeeController()
        {
            _employees = new List<Employee>
            {
               new Employee{

                Id = 1, Name = "Martin", Surname = "Simpson",
                BirthDate = new DateTime(1992, 12, 3),
                Position = "Marketing Expert", Image="/images/Martin.jpg"
                },
                      new Employee
                {
                Id = 2, Name = "Jacob", Surname = "Hawk",
                BirthDate = new DateTime(1995, 10, 2), Position = "Manager", Image="/images/Jacob.jpg"
                },
                      new Employee
                {
                Id = 3, Name = "Elizabeth", Surname = "Geil",
                BirthDate = new DateTime(2000, 1, 7),
                Position = "Software Engineer", Image="/images/Elizabeth.jpg"
                },
                      new Employee
                {
                Id = 4, Name = "Kate", Surname =  "Metain",
                BirthDate = new DateTime(1997, 2, 13),
                Position = "Admin", Image="/images/Kate.jpg"
                },
                      new Employee
                {
                Id = 5, Name = "Michael", Surname = "Cook",
                BirthDate = new DateTime(1990, 12, 25),
                Position = "Marketing expert", Image="/images/Michael.jpg"
                },
                            new Employee
                {
                Id = 6, Name = "John", Surname = "Snow",
                BirthDate = new DateTime(2001, 7, 15),
                Position = "Software Engineer", Image="/images/John.jpg"
                },
                             new Employee
                {
                Id = 7, Name = "Nina", Surname = "Soprano",
                BirthDate = new DateTime(1999, 9, 30),
                Position = "Software Engineer", Image="/images/Nina.jpg"
                },
                             new Employee
                {
                Id = 8, Name = "Tina", Surname = "Fins",
                BirthDate = new DateTime(2000, 5, 14),
                Position = "Team Leader", Image="/images/Tina.jpg"
                }
            };
        }

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id = 1)
        {

            var movie = _employees.FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}