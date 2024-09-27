using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class SupplierAddress : IAddress
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("Location")]
        public int CountryID { get; set; }
        public virtual Location Location { get; set; }
        public int CreatedByID { get; set; }
         [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        [ForeignKey("ModifiedByID")]
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Contact { get; set; }
        public string Address { get ; set ; }
        public string Code { get; set ; }
        public int CityID { get ; set ; }
    }
}
