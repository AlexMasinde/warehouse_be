using JWarehouseSystem.BackEnd.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Contact : IContact
    {
        [Key]
       public int ID { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
      
        public DateTime ModifiedOn { get; set; }
    }
}
