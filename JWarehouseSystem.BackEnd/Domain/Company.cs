using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Company : ICompany
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
