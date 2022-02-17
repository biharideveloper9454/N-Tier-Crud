using CommonLayer;
using CommonLayer.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Interface
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        List<EmployeeCompanyViewModel> AllRecord();
        Employee GetEmployeeById(int id);
        Employee CreateEmployee(EmployeeCreateModel employee);
        //Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
    }
}
