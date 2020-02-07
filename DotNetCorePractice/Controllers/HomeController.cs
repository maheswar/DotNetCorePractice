using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCorePractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCorePractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRespository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRespository = employeeRepository;
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public ViewResult Index()
        {
            return View(_employeeRespository.GetAllEmployees());
        }

        //[Route("Home/Details/{id}")]
        public IActionResult Details(int id)
        {
            return View(_employeeRespository.GetEmployee(id));
        }

        public ObjectResult Employee(int id)
        {
            return new ObjectResult(_employeeRespository.GetEmployee(id));
        }
    }
}