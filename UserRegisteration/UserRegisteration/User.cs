using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisteration
{
    class User
    {
        //Validating First Name
        public void UserFirstName()
        {
            Console.WriteLine("Enter First Name : ");
            string firstName = Console.ReadLine();

            string namePattern = @"^[A-Z]{1}[a-z]{2,}$";

            Regex regexFirstName = new Regex(namePattern);

            if (regexFirstName.IsMatch(firstName))
            {
                Console.WriteLine("First Name : " + firstName);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
