using System;
using System.Collections.Generic;
using System.Text;

namespace MyPersonnels
{
    enum GenderType
    {
        Female,
        Male
    }
    class PersonnelAccount
    {
        private static int lastaccountnumber = 0;
        /// <summary>
        /// ACcount Entry for the user
        /// </summary>
        #region UserInformation
        public int AccountNumber { get; }
        public string Name { get; set; }    
        public GenderType Gender { get; set; }
        public int Dateofbirth { get; set; }

        public decimal Deposit { get; set; }
        //public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDatetime { get; }

        #endregion

        #region Constructor

        public PersonnelAccount ()
        {
            AccountNumber = ++lastaccountnumber;
            CreatedDatetime = DateTime.Now;
        }

        #endregion

        #region Method-Deposit
        //public void Deposit 
        #endregion
    }


}
