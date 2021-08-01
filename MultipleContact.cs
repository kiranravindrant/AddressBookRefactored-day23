using System;
using System.Collections.Generic;
using System.Text;

namespace AddressbookProgram
{

    public class AddMultipleContact
    {
        
        private static List<Contact> contacts = new List<Contact>();    
        public static void AddMember()
        {
            Console.Write("Enter Number of contacts you want to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)                                  //loop initiated here to reapeat adding contact.
            {
        
                Contact person = new Contact();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                person.Address = Console.ReadLine();
                Console.Write("Enter City: ");
                person.City = Console.ReadLine();
                Console.Write("Enter State: ");
                person.State = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                person.Zip = (Console.ReadLine());

         
                while (true)
                {
                    Console.Write("Enter Phone Number: ");
                    string phNo = Console.ReadLine();
                    if (phNo.Length == 10)
                    {
                        person.PhoneNumber= phNo;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                    }
                }
   
                while (true)
                {
                    Console.Write("Enter Email-id: ");
                    string emailId = Console.ReadLine();
                    if (emailId.Contains("@"))
                    {
                        person.Email = emailId;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                    }
                }
                contacts.Add(person);                                                   /////////Adding to List

                Console.WriteLine("#Added Successfully#");
                numOfContacts--;
            }
        }


        public static void ViewContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("############## Contact List #####################");
                foreach (var item in contacts)
                {
                    PrintValues(item);
                  
                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

      
        public static void PrintValues(Contact item)
        {
            Console.WriteLine("First Name : " + item.FirstName);
            Console.WriteLine("Last Name : " + item.LastName);
            Console.WriteLine("Address : " + item.Address);
            Console.WriteLine("City : " + item.City);
            Console.WriteLine("State : " + item.State);
            Console.WriteLine("Zip Code : " + item.Zip);
            Console.WriteLine("Phone Number : " + item.PhoneNumber);
            Console.WriteLine("Email Id : " + item.Email);

        }

        public static void EditDetails()
        {
         
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (editName.ToLower() == x.FirstName.ToLower())
                    {
                        while (true)
                        {
                           
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.FirstName = Console.ReadLine();
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.LastName = Console.ReadLine();
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.Address = Console.ReadLine();
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.City = Console.ReadLine();
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.State = Console.ReadLine();
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.Zip = (Console.ReadLine());
                                    Console.WriteLine("# MODIFIED #");
                                    break;
                                case 7:
                                    while (true)
                                    {
                                        Console.Write("Enter new Phone Number: ");
                                        string phNo = Console.ReadLine();
                                        if (phNo.Length == 10)
                                        {
                                            x.PhoneNumber= phNo;
                                            Console.WriteLine("# MODIFIED #");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                                        }
                                    }
                                    break;
                                case 8:
                                    while (true)
                                    {
                                        Console.Write("Enter new Email-id: ");
                                        string emailId = Console.ReadLine();
                                        if (emailId.Contains("@"))
                                        {
                                            x.Email= emailId;
                                            Console.WriteLine("# MODIFIED #");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                                        }
                                    }
                                    break;
                                case 9:
                                    Environment.Exit(0);
                                    break;

                            }
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }

        public static void DeleteDetails()
        {
            int f = 0;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (deleteName.ToLower() == x.FirstName.ToLower())
                    {
                        Console.WriteLine("# DELETED SUCCESSFULLY #");
                        Console.WriteLine("You have deleted " + x.FirstName + " contact");
                        contacts.Remove(x);
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.WriteLine("The name you have entered not in the address book");
                }

            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }



    }








}

