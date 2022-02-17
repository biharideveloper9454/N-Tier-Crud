using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Interface
{
    public interface ICompany
    {
        List<Company> GetCompanies();
    }
}
