using JWarehouseSystem.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JWarehouseSystem.Common.Domain
{
    public class User :Entity, IUser 
     {
        [Key]
        public new int ID { get; set; }
        public string Username { get; set; }
      //  public string Password { get; set; }
        public bool ChangePasswordRequired { get; set; }
        public DateTime LastPasswordChange { get; set; }
        public int PasswordChangedBy { get; set; }
        public string PasswordChangeVerificationCode { get; set; }
        public DateTime VerificationCodeEffectiveDate { get; set; }
        public DateTime VerificationCodeExpiryDate { get; set; }
        public DateTime VerificationCodeUsageDate { get; set; }
        public byte[] Salt { get; set;}
        byte[] IUser.Password { get; set;}
        [ForeignKey("CreatedByID")]
        int IUser.CreatedBy { get; set;}
        [ForeignKey("ModifiedByID")]
        int IUser.ModifiedBy { get; set;}
    }
}
