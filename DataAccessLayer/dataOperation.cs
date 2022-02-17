using CommonLayer;
using CommonLayer.Models;
using CommonLayer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class dataOperation
    {
        private ApplicationContext context;
        public dataOperation()
        {
            context = new ApplicationContext();
        }
        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
        public List<EmployeeCompanyViewModel> AllRecord()
        {
            var emps = (from e in context.Employees
                       join
                       c in context.Companies
                       on e.Company.Id equals c.Id
                       select new EmployeeCompanyViewModel()
                       {
                           Id=e.Id,
                           FirstName=e.FirstName,
                           LastName=e.LastName,
                           City=e.City,
                           Age=e.Age,
                           Gender=e.Gender,
                           Company=c.Name,
                           EmployerName=e.EmployerName,
                           Experience=e.Experience,
                           HighestQualification=e.HighestQualification,
                           LastWorkingDate=e.LastWorkingDate,
                           PassingYear=e.PassingYear,
                           Percentage=e.Percentage  
                       }).ToList();
            return emps;
        }
        public Employee DeleteEmployee(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            return emp;
        }
        public Employee CreateEmployee(EmployeeCreateModel model)
        {
            int id = model.Company;
            var cmp = context.Companies.SingleOrDefault(e => e.Id == id);
            var emp = new Employee()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                Company=cmp,
                City=model.City,
                Age=model.Age,
                Gender=model.Gender,
                Experience=model.Experience,
                LastWorkingDate=model.LastWorkingDate,
                EmployerName=model.EmployerName,
                HighestQualification=model.HighestQualification,
                Percentage=model.Percentage,
                PassingYear=model.PassingYear  
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            return emp;
        }
        public Employee GetEmployeesById(int id)
        {
            var emp = context.Employees.Where(e => e.Id == id).FirstOrDefault();
            if (emp == null)
            {
                return emp;

            }
            else
            {
                var data = new EmployeeCreateModel()
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Company = emp.Company.Id,
                    City = emp.City,
                    Age = emp.Age,
                    Gender = emp.Gender,
                    Experience = emp.Experience,
                    LastWorkingDate = emp.LastWorkingDate,
                    EmployerName = emp.EmployerName,
                    HighestQualification = emp.HighestQualification,
                    Percentage = emp.Percentage,
                    PassingYear = emp.PassingYear
                };
                //return data;
                return emp;
            }
           
            
        }
    }
}
