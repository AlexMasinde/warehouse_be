using JWarehouseSystem.BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWMS.API.Data
{
    public static class InitialDataLocations
    {
        public static void Initialize(AWMSAPIDBContext context) {
            //Look for any Region then create
            if (!context.Region.Any())
            {
                var region = new Region()
                {
                    Name = "Nairobi Region",
                    Description = "Nairobi area ,region 1",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                var region2 = new Region()
                {
                    Name = "Coastal Region",
                    Description = "Coastal area,region 2",
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                context.Region.Add(region);
                context.Region.Add(region2);
                context.SaveChanges();
            }

            //Look for any Location then create
            if (!context.Location.Any())
            {
                var location = new Location()
                {
                    Name = "Nairobi",
                    Description = "Testing",
                    RegionID = 1,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                var location2 = new Location()
                {
                    Name = "Mombasa",
                    Description = "Malindi Area",
                    RegionID =2,
                    ModifiedByID = 1,
                    CreatedByID = 1,
                    CreateOn = DateTime.Now,
                    ModifiedOn = DateTime.Now

                };
                context.Location.Add(location);
                context.Location.Add(location2);
                context.SaveChanges();
            }

            //Look for any Address then create
            //if (!context.CustomerAddress.Any())
            //{
            //    var address = new CustomerAddress()
            //    {
            //        CustomerID=1,
            //        CountryID = 1,
            //        Contact = "Monrovia Street",
            //        ModifiedByID = 1,
            //        CreatedByID = 1,
            //        CreateOn = DateTime.Now,
            //        ModifiedOn = DateTime.Now

            //    };
            //    context.CustomerAddress.Add(address);
            //    context.SaveChanges();
            //}

            //Look for any Countries then create
            if (!context.Country.Any())
            {
                var countries = new Country[]{
                new Country{Name = "Kenya",  Code= "KE",NumericCode="404",CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now},
                new Country{Name = "Uganda", Code= "UG", NumericCode="800",CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now},
                new Country{Name = "Tanzania",Code= "TZ",NumericCode="834",CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now}
                };

                context.Country.AddRange(countries);
                context.SaveChanges();
            }

            //Look for any Currencies then create
            if (!context.Currency.Any())
            {
                var currencies = new Currency[]{
                new Currency{Name = "Euro", Code= "EUR",Number=978,CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now},
                new Currency{Name = "US Dollar", Code= "USD",Number=840, CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now},
                new Currency{Name = "Pound Sterling", Code= "GBP",Number=826,CreatedByID = 1,ModifiedByID = 1, ModifiedOn = DateTime.Now,CreateOn = DateTime.Now}
                };

                context.Currency.AddRange(currencies);
                context.SaveChanges();
            }



        }
    }
}
