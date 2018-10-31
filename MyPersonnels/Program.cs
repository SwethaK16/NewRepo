using System;

namespace MyPersonnels
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance from obeject (properties in class)

            var PAccount = WATA.CreateAccount("Swetha",1/1/1111, 200, "swe@test.com");
            //{
            //    //AccountNumber = 1234,
            //    Name = "Swetha",
            //    Gender = "Female",
            //    Deposit = 100,
            //    EmailAddress = "swe@gmail.com",
            //    CreatedDatetime = DateTime.Now
            //};

            Console.WriteLine ($"AN: { PAccount.AccountNumber}, Name: {PAccount.Name}, Gender: {PAccount.Gender}, Deposit: {PAccount.Deposit:C}, Email: {PAccount.EmailAddress}, CreatedDate: {PAccount.CreatedDatetime}");
                
        }
    }
}
