using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using Newtonsoft.Json;

namespace JWarehouseSystem.BackEnd.Domain
{
  
    public class Employee : IEmployee
    {
        public Employee() {
         
        }
        public int ID { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Identity { get; set;}
        public string Telephone { get; set;}
        public string Email { get; set;}
       
        public byte[] Photo { get; set;}
        public string Number { get; set;}
        public string Department { get; set;}
        public string Designation { get; set;}
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
