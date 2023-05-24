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
                UserLastName();
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }

        public void UserLastName()
        {
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();

            string namePattern = @"^[A-Z]{1}[a-z]{2,}$";

            Regex regexLastName = new Regex(namePattern);

            if (regexLastName.IsMatch(lastName))
            {
                Console.WriteLine("Last Name : " + lastName);
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
