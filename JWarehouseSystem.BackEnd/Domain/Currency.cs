using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Currency : ICurrency
    {
        public int ID { get; set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set;}
        public int Number { get; set; }
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
