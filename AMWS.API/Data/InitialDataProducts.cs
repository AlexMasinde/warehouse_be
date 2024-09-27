using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWarehouseSystem.BackEnd.Domain;
using JWarehouseSystem.Common;

namespace AWMS.API.Data
{
    public class InitialDataProducts
    {
        public static void Initialize(AWMSAPIDBContext context)
        {
            if (!context.ProductCategory.Any())
            {
                var categories = new ProductCategory[]
                {
                    new ProductCategory
                    {
                        Name = "Computers",
                        Description = "This is one of the Categories",
                        CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now
                    },
                    new ProductCategory
                    {
                        Name = "Clothes",
                        Description = "Designer Clothline",
                        CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now
                    }
                };

                context.ProductCategory.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Product.Any())
            {
                var products = new Product[]
                {
                    new Product
                    {
                        Name = "Laptop 1",
                        Brand = "HP",
                        Description = "Skyline technologies processors",
                        Price = 200000,
                        ProductCategoryID = 1,
                        SKU = "SKU1",
                        CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now,
                        ProductCodes = new List<ProductCode>
                        {
                            new ProductCode { CodeString = "RFID123456", Type = ProductCodeType.RFID, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, },
                            new ProductCode { CodeString = "BARCODE123456", Type = ProductCodeType.Barcode, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, },
                            new ProductCode { CodeString = "QRCODE123456", Type = ProductCodeType.QRCode, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, }
                        }
                    },
                    new Product
                    {
                        Name = "Laptop 2",
                        Brand = "Lenovo",
                        Description = "Gaming world optimized",
                        Price = 180000,
                        ProductCategoryID = 1,
                        SKU = "SKU2",
                        CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now,
                        ProductCodes = new List<ProductCode>
                        {
                            new ProductCode { CodeString = "RFID987654", Type = ProductCodeType.RFID, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, },
                            new ProductCode { CodeString = "BARCODE987654", Type = ProductCodeType.Barcode, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now,}
                        }
                    },
                    new Product
                    {
                        Name = "Laptop 3",
                        Brand = "SumSang",
                        Description = "Clarity redefined",
                        Price = 230000,
                        ProductCategoryID = 1,
                        SKU = "SKU3",
                        CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now,
                        ProductCodes = new List<ProductCode>
                        {
                            new ProductCode { CodeString = "RFID192837", Type = ProductCodeType.RFID, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, },
                            new ProductCode { CodeString = "QRCODE192837", Type = ProductCodeType.QRCode, CreatedByID = 1,
                        ModifiedByID = 1,
                        ModifiedOn = DateTime.Now,
                        CreateOn = DateTime.Now, }
                        }
                    }
                };

                context.Product.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
