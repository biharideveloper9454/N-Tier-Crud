using CommonLayer;
using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class CompanyDataOperation
    {
        private ApplicationContext context;
        public CompanyDataOperation()
        {
            context = new ApplicationContext();
        }
        public List<Company> GetCompanies()
        {
            var cmp = context.Companies.ToList();
            return cmp;
        }
    }
}
