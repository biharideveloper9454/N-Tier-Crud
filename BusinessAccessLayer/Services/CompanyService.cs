using BusinessAccessLayer.Interface;
using CommonLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccessLayer.Services
{
    public class CompanyService:ICompany
    {
        private CompanyDataOperation CompanyDataOperation;
        public CompanyService()
        {
            CompanyDataOperation = new CompanyDataOperation();
        }

        public List<Company> GetCompanies()
        {
            var cmp=CompanyDataOperation.GetCompanies();
            return cmp;
        }
    }
}
