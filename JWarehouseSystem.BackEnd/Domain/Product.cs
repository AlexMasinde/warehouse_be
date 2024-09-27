using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Product : IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid GUID { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public int ProductCategoryID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductCode> ProductCodes { get; set; } = new HashSet<ProductCode>();
        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
