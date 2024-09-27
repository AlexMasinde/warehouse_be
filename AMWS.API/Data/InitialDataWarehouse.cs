using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataWarehouse
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            //Look for any Warehouse then create
            if (!context.Warehouse.Any())
            {
                var warehouse = new Warehouse()
                {
                    Name = "Warehouse A",
                    Description = "Another Testing Warehouse",
                    LocationID = 1,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    ModifiedOn = DateTime.Now,
                    CreateOn = DateTime.Now
                };

                context.Warehouse.Add(warehouse);
                context.SaveChanges();
            }

                //Look for any Docks then create
                if (!context.Dock.Any())
            {
                var dock = new Dock()
                {
                    DockName = "Dock A",
                    Description = "Test Dock A",
                    IsActive = true,
                    Location = "West Wing",
                    Warehouse = new Warehouse() { 
                        Name = "Warehouse B", 
                        Description = "Testing Warehouse",
                        LocationID = 1,
                        ModifiedByID = 1,
                        CreatedByID = 1, 
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now
                    },
                    CreatedByID = 1,
                    ModifiedByID = 1,
                    ModifiedOn=DateTime.Now,
                    CreateOn=DateTime.Now
                
                };

                context.Dock.Add(dock);
                context.SaveChanges();
            }

            //Look for any Ship then create
            if (!context.Carrier.Any())
            {
                var ship = new Carrier()
                {
                    Name = "Omega Star",
                    Code="002NZ",
                    Capacity="1000 Tonnes",
                    Description="Ships only Motor Vehicles",
                    CreatedByID = 1,
                    ModifiedByID = 1,
                    ModifiedOn = DateTime.Now,
                    CreateOn = DateTime.Now

                };

                context.Carrier.Add(ship);
                context.SaveChanges();
            }

        }
    }
}
