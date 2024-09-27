using JWarehouseSystem.BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace AWMS.API.Data
{
    public static class InitialDataAreaPurpose
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            /// <summary>
            ///   Loading = 1, Unloading = 2, Reception = 3, Picking = 4, Packing = 5 
            /// </summary>
            if (!context.AreaPurpose.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Enable IDENTITY_INSERT for the AreaPurpose table
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT AreaPurpose ON");

                        var areaPurposes = new AreaPurpose[]
                        {
                            new AreaPurpose{ ID=1, AreaID = 1, Purpose="Loading", CreatedByID = 1, ModifiedByID = 1, ModifiedOn = DateTime.Now, CreateOn = DateTime.Now },
                            new AreaPurpose{ ID=2, AreaID = 1, Purpose="Unloading", CreatedByID = 1, ModifiedByID = 1, ModifiedOn = DateTime.Now, CreateOn = DateTime.Now },
                            new AreaPurpose{ ID=3, AreaID = 1,  Purpose="Reception", CreatedByID = 1, ModifiedByID = 1, ModifiedOn = DateTime.Now, CreateOn = DateTime.Now },
                            new AreaPurpose{ ID=4, AreaID = 2, Purpose="Picking", CreatedByID = 1, ModifiedByID = 1, ModifiedOn = DateTime.Now, CreateOn = DateTime.Now },
                            new AreaPurpose{ ID=5, AreaID = 2, Purpose="Packing", CreatedByID = 1, ModifiedByID = 1, ModifiedOn = DateTime.Now, CreateOn = DateTime.Now },
                        };

                        context.AreaPurpose.AddRange(areaPurposes);
                        context.SaveChanges();

                        // Disable IDENTITY_INSERT for the AreaPurpose table
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT AreaPurpose OFF");

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
