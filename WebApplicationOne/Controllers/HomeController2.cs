using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplicationOne.Models;

namespace WebApplicationOne.Controllers
{
    public class HomeController2 : Controller
    {
       static List<Employee> employeesList = new List<Employee>() {
        new Employee(){Id=1, Name="Suresh",DOB=new DateTime(day:01,month:8,year:2023),des="dev",salary=12055},
        new Employee(){Id=2, Name="Narendra",DOB=new DateTime(day:01,month:5,year:2024),des="Tester",salary=15585}
            };
        public IActionResult Index()
        {
            return View(employeesList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee!= null)
            {
                if (ModelState.IsValid)
                {
                    employeesList.Add(employee);
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee emp = employeesList.SingleOrDefault(e => e.Id == id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Employee emp = employeesList.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                employeesList.Remove(emp);
            }
            return RedirectToAction("Index");
        }
    }
}
