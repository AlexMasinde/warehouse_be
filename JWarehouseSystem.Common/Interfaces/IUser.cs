using System;
using System.Collections.Generic;
using System.Text;

namespace JWarehouseSystem.Common.Interfaces
{
    public interface IUser :IEntity
    {
        string Username { get; set; }
       // string Password { get; set; }
         byte[] Password { get; set; }
         byte[] Salt { get; set; }
        Boolean ChangePasswordRequired { get; set; }
        DateTime LastPasswordChange { get; set; }
        int PasswordChangedBy { get; set; }
        string PasswordChangeVerificationCode  { get; set; }
        DateTime VerificationCodeEffectiveDate { get; set; }
        DateTime VerificationCodeExpiryDate { get; set; }
        DateTime VerificationCodeUsageDate { get; set; }
        int CreatedBy { get; set; }
        //DateTime CreateOn { get; set; }
        int ModifiedBy { get; set; }
       // DateTime ModifiedOn { get; set; }
    }
}
