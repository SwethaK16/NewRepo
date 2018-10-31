using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersonnels
{
    //Factory
    class WATA
    {
        public static PersonnelAccount CreateAccount(string Name, int Dateofbirth, decimal Deposit, string EmailAddress, GenderType Gender = GenderType.Female)
        {
          var PAccount = new PersonnelAccount
          {
            Name = Name,
            Gender = Gender,
            Dateofbirth = Dateofbirth,
            Deposit = Deposit,
            EmailAddress = EmailAddress
           };
            if (Deposit>0)
            {
                PAccount.Deposit=200; 
            }

            return PAccount;

        }
        
    }
}
