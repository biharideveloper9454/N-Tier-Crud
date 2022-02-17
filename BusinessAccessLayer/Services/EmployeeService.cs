using BusinessAccessLayer.Interface;
using CommonLayer;
using CommonLayer.Models.ViewModel;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Services
{
    public class EmployeeService : IEmployee
    {
        private dataOperation dataOperation;
        public EmployeeService()
        {
            dataOperation = new dataOperation();
        }

        public List<EmployeeCompanyViewModel> AllRecord()
        {
            var emps = dataOperation.AllRecord();
            return emps;
        }

        public Employee CreateEmployee(EmployeeCreateModel employee)
        {
            var emp = dataOperation.CreateEmployee(employee);
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp=dataOperation.DeleteEmployee(id);
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = dataOperation.GetEmployeesById(id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            var emp = dataOperation.GetEmployees();
            return emp;
        }
        
    }
}
