using System;
using System.Collections.Generic;
using System.Text;
using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class Driver :Entity, IDriver
    {
        public  Driver() {
           
        }
        public string Identity { get; set;}
        
        public byte[] Photo { get; set;}
      
    }
}
