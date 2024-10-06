using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataContact
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.Contact.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var contacts = new Contact[]
                        {
                            new Contact
                            {
                                Identity = "C001",
                                FirstName = "John",
                                LastName = "Doe",
                                Telephone = "123-456-7890",
                                Email = "john.doe@example.com",
                                Description = "Primary contact",
                                IsActive = true,
                                CreatedByID = 1,
                                CreateOn = DateTime.Now,
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now
                            }
                        };

                        context.Contact.AddRange(contacts);
                        context.SaveChanges();

                        // Commit the transaction
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Rollback the transaction if something goes wrong
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}