using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataCompany
    {
        public static void Initialize(AWMSAPIDBContext context)
        {

            var company = new Company()
            {
                Name = "Company B",
                ContactID = 1,
                ModifiedByID = 1,
                CreatedByID = 1,
                ModifiedOn = DateTime.Now,
                CreateOn = DateTime.Now
            };
            context.Company.Add(company);
            context.SaveChanges();

        }
    }
}