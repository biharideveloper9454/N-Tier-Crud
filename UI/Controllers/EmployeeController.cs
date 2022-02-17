using BusinessAccessLayer.Interface;
using CommonLayer;
using CommonLayer.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee employeeService;
        private readonly ICompany companyService;

        public EmployeeController(IEmployee employeeService, ICompany companyService)
        {
            this.employeeService = employeeService;
            this.companyService = companyService;
        }

        public IActionResult Index()
        {
            var emps = employeeService.AllRecord();
            return View(emps);
            
        }
        public IActionResult Delete(int id)
        {
            var result = employeeService.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            var company = companyService.GetCompanies();
            ViewBag.company = company;
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var result=employeeService.CreateEmployee(model);
            return RedirectToAction("Index");
        }


        
        public IActionResult Registration()
        {
            var company = companyService.GetCompanies();
            ViewBag.company = company;
            return View();
        }

        [HttpPost]
        public IActionResult Registration(EmployeeCreateModel model)
        {
            var emps = employeeService.CreateEmployee(model);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var company = companyService.GetCompanies();
            ViewBag.company = company;
            var emp=employeeService.GetEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeCreateModel model)
        {
            return View();
        }




        public IActionResult Details(int id)
        {
           var data= employeeService.GetEmployeeById(id);
            return View(data);
            
        }
    }
}
