using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataAddresses
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            //Look for any Customer Address then create
            if (!context.CustomerAddress.Any())
            {
                var address = new CustomerAddress()
                {
                    CustomerID = 1,
                    Contact = "Customer 1 Nairobi",
                    CountryID = 1,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    ModifiedOn = DateTime.Now,
                    CreateOn = DateTime.Now
                };
                var address2 = new CustomerAddress()
                {
                    CustomerID = 1,
                    Contact = "Customer 1 Coast ",
                    CountryID = 2,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    ModifiedOn = DateTime.Now,
                    CreateOn = DateTime.Now
                };

                context.CustomerAddress.Add(address);
                context.CustomerAddress.Add(address2);
                context.SaveChanges();
            }



        }
    }
}
