using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;

namespace AWMS.API.Data
{
    public static class InitialDataCompanyAddress
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.CompanyAddress.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var companyAddresses = new CompanyAddress[]
                        {
                            new CompanyAddress
                            {
                                CompanyID = 2,
                                CountryID = 1,
                                CityID = 1,
                                Address = "123 Main St, City A",
                                Contact = "contact@companya.com",
                                Code = "ADDR001",
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-10),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-5)
                            },
                            new CompanyAddress
                            {
                                CompanyID = 3,
                                CountryID = 1,
                                CityID = 1,
                                Address = "456 Elm St, City B",
                                Contact = "contact@companyb.com",
                                Code = "ADDR002",
                                CreatedByID = 1,
                                CreateOn = DateTime.Now.AddDays(-8),
                                ModifiedByID = 1,
                                ModifiedOn = DateTime.Now.AddDays(-4)
                            }
                        };

                        context.CompanyAddress.AddRange(companyAddresses);
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
