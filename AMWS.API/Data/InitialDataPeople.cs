using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataPeople
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            //Look for any Users then create
            if (!context.User.Any())
            {
                var user = new User()
                {
                    FirstName = "James",
                    LastName = "Karanja",
                    Username = "jkaranja",
                    Telephone = "072166665",
                    Email = "karanja@email.com",
                    ChangePasswordRequired = false,
                    LastPasswordChange = DateTime.Now,
                    VerificationCodeEffectiveDate = DateTime.Now,
                    VerificationCodeExpiryDate = DateTime.Now.AddDays(1),
                    VerificationCodeUsageDate = DateTime.Now,
                    CreatedByID = 1,
                    ModifiedByID = 1,
                    EntityType = JWarehouseSystem.Common.EntityType.User,
                    Enabled = true
                };
                var user2 = new User()
                {
                    FirstName = "Muholo",
                    LastName = "Henry",
                    Username = "hmuholo",
                    Telephone = "0755844221",
                    Email = "hmuholo@email.com",
                    ChangePasswordRequired = false,
                    LastPasswordChange = DateTime.Now,
                    VerificationCodeEffectiveDate = DateTime.Now,
                    VerificationCodeExpiryDate = DateTime.Now.AddDays(2),
                    VerificationCodeUsageDate = DateTime.Now,
                    CreatedByID = 1,
                    ModifiedByID = 1,
                    EntityType = JWarehouseSystem.Common.EntityType.User,
                    Enabled = true
                };

                context.User.Add(user);
                context.User.Add(user2);
                context.SaveChanges();
            }


            //Look for any Employees then create
            if (!context.Employee.Any())
            {
                var employee = new Employee()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Identity = "222222",
                    Telephone = "072155555",
                    Email = "john@email.com",
                    Number = "001",
                    Department = "Sales",
                    Designation = "Supervisor",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                context.Employee.Add(employee);
                context.SaveChanges();
            }

            //Look for any Customer then create
            if (!context.Customer.Any())
            {
                var customer = new Customer()
                {
                    FirstName = "Insignia",
                    LastName = "George",
                    Identity = "666667",
                    Telephone = "072199999",
                    Email = "george@email.com",
                    Website = "www.insignia.co.ke",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                context.Customer.Add(customer);
                context.SaveChanges();
            }

            //Look for any Driver then create
            if (!context.Driver.Any())
            {
                var driver = new Driver()
                {
                    FirstName = "Evans",
                    LastName = "Ochieng",
                    MiddleName = "Komondi",
                    Enabled = true,
                    EntityType = JWarehouseSystem.Common.EntityType.Driver,
                    Identity = "788884",
                    Telephone = "072199999",
                    Email = "evans@email.com",
                    Title = "MR.",
                    Website = "www.evans.co.ke",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now
                };
                context.Driver.Add(driver);
                context.SaveChanges();
            }

            //Look for any Supplier then create
            if (!context.Supplier.Any())
            {
                var supplier = new Supplier()
                {
                    Name = "Davids & Sons Ltd",
                    Telephone = "072199999",
                    Email = "evans@email.com",
                    Identity = "PIN:55541111111",
                    Website = "www.dave.co.ke",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now
                };
                context.Supplier.Add(supplier);
                context.SaveChanges();
            }
        }
    }
}
