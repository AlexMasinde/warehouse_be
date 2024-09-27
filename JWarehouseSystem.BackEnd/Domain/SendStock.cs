using JWarehouseSystem.BackEnd.Interfaces;
using JWarehouseSystem.Common.Domain;
using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWarehouseSystem.BackEnd.Domain
{
    public class SendStock : ISendStock
    {

        public int ID { get; set; }
        public int RequestTransferID { get; set; }
        public virtual RequestTransfer RequestTransfer {get;set;}
        public DateTime SendStockDate { get; set;}
        public DateTime ReleaseDate { get; set;}
        public int SentByID { get; set;}
        public virtual Employee SentBy { get; set; }
        public string Notes { get; set;}
        public int CreatedByID { get; set; }
        public DateTime CreateOn { get; set; }
        public int ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
