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
                Console.WriteLine();
                UserLastName();
            }
            else
            {
                Console.WriteLine("Invalid First Name");
                Console.WriteLine();
                UserFirstName();
            }
        }

        //Validating Last Name
        public void UserLastName()
        {
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();

            string namePattern = @"^[A-Z]{1}[a-z]{2,}$";

            Regex regexLastName = new Regex(namePattern);

            if (regexLastName.IsMatch(lastName))
            {
                Console.WriteLine("Last Name : " + lastName);
                Console.WriteLine();
                UserEmail();
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
                Console.WriteLine();
                UserLastName();
            }
        }

        //Validating Email
        public void UserEmail()
        {
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();

            string emailPattern = @"^\w[a-z]{2,}\.\w[a-z]{2,}@[a-z]{1,}\.[a-z]{2}\.[a-z]{2}$";

            Regex regexEmail = new Regex(emailPattern);
            
            if (regexEmail.IsMatch(email))
            {
                Console.WriteLine("Email : " + email);
                Console.WriteLine();
                UserPhoneNumber();
            }
            else
            {
                Console.WriteLine("Invalid Email");
                Console.WriteLine();
                UserEmail();
            }
        }

        //Validating Phone Number
        public void UserPhoneNumber()
        {
            Console.WriteLine("Enter Phone Number : ");
            string phoneNumber = Console.ReadLine();

            string phonePattern = @"\d{2}\s\d{10}$";
            
            Regex regexPhoneNumber = new Regex(phonePattern);

            if (regexPhoneNumber.IsMatch(phoneNumber))
            {
                Console.WriteLine("Phone Number : " + phoneNumber);
                Console.WriteLine();
                UserPassword();
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
                Console.WriteLine();
                UserPhoneNumber();
            }
        }

        public void UserPassword()
        {
            Console.WriteLine("Enter the Password : ");
            string password = Console.ReadLine();

            String passwordPattern = @".{8,}$";

            Regex regexPassword = new Regex(passwordPattern);
            
            if (regexPassword.IsMatch(password))
            { 
                Console.WriteLine("Password : " + password);
                Console.WriteLine();
            }
            else 
            { 
                Console.WriteLine("Invalid Password");
                Console.WriteLine();
                UserPassword();
            }
        }
    }
}
