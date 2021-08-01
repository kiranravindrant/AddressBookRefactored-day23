using System;
using System.Collections.Generic;
using System.Text;

namespace AddressbookProgram
{
     public class AddAndRetrieveContact
    {
        public static List<Contact> AddressBook = new List<Contact>();

        public void EnterInput()
        {
            Contact objcontact = new Contact();

            Console.Write("Enter the First Name : ");
            objcontact.FirstName = Console.ReadLine();


            Console.Write("Enter the last Name  : ");
            objcontact.LastName = Console.ReadLine();

            Console.Write("Enter the address  :");
            objcontact.Address = Console.ReadLine();

            Console.Write("Enter the City  :");
            objcontact.City = Console.ReadLine();

            Console.WriteLine("Enter the state  : ");
            objcontact.State = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Zip Code  : ");
                string tempv = Console.ReadLine();

                if (tempv.Length == 6)
                {
                    objcontact.Zip = tempv;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 6 digit Zip Code.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Phone Number: ");
                string tempv2 = Console.ReadLine();

                if (tempv2.Length == 10)
                {
                    objcontact.PhoneNumber = tempv2;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 10 digit Phone Number.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Email Address: ");
                string tempv3 = Console.ReadLine();

                if (tempv3.Contains("@"))
                {
                    objcontact.Email = tempv3;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Email Address.");
                }
            }

            AddressBook.Add(objcontact);

            Console.WriteLine("..................");

        }



        public void ViewTheDetails()
        {
            if (AddressBook.Count > 0)
            {
                foreach ( var item in AddressBook)
                {
                    PrintTheDetails(item);
                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");

            }
        }

        public void PrintTheDetails(Contact item)
        {
            Console.WriteLine("First Name :   " + item.FirstName);
            Console.WriteLine("Last Name :    " + item.LastName);
            Console.WriteLine("Address :      " + item.Address);
            Console.WriteLine("City    :      " + item.City);
            Console.WriteLine("State   :      " + item.State);
            Console.WriteLine("Zip     :      " + item.Zip);
            Console.WriteLine("Phone Number  : " + item.PhoneNumber);
            Console.WriteLine("email  :       " + item.Email);


        }


    }
}
