using JWarehouseSystem.BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using JWarehouseSystem.BackEnd.Interfaces;
using System;
using System.Linq;
using JWarehouseSystem.Common;

namespace AWMS.API.Data
{
    public static class InitialDataArea
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            /// <summary>
            ///   Loading = 1, Unloading = 2, Reception = 3, Picking = 4, Packing = 5 
            /// </summary>
            if (!context.Area.Any())
            {
                using (IDbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Enable IDENTITY_INSERT for the AreaPurpose table
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Area ON");

                        var areas = new Area[]
                         {
                            new Area { ID = 1, Name = "Area 1", Zone = "Zone A", Status = AreaStatus.Active, Description = "Primary loading area", IsActive = true, CreatedByID = 1, ModifiedByID = 1, CreateOn = DateTime.Now, ModifiedOn = DateTime.Now },
                            new Area { ID = 2, Name = "Area 2", Zone = "Zone B", Status = AreaStatus.Active, Description = "Secondary unloading area", IsActive = true, CreatedByID = 1, ModifiedByID = 1, CreateOn = DateTime.Now, ModifiedOn = DateTime.Now }
                         };

                        context.Area.AddRange(areas);
                        context.SaveChanges();

                        // Disable IDENTITY_INSERT for the AreaPurpose table
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Area OFF");

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
