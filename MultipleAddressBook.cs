using System;
using System.Collections.Generic;
using System.Text;

namespace AddressbookProgram
{
    class MultipleAddressBook
    {


        

        private List<Contact> objcontact;
        //Address book dictioanry to store a value(list of contacts) corresponding to keyname
        private static Dictionary<string, List<Contact>> AddressBookDictionary = new Dictionary<string, List<Contact>>();
        public void AddMember()
        {
            string addressBookName;
            objcontact = new List<Contact>();
            while (true)
            {
                Console.WriteLine("Enter The Name of the Address Book");
                addressBookName = Console.ReadLine();
               
                if (AddressBookDictionary.Count > 0)
                {
                    if (AddressBookDictionary.ContainsKey(addressBookName)) //validation for duplicatename
                    {
                        Console.WriteLine(" Address book already exist,please change name");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write("Enter Number of contacts you want to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)
            {
                //object for contact class
                Contact obj = new Contact();

                Console.Write("Enter First Name: ");
                obj.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                obj.LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                obj.Address = Console.ReadLine();
                Console.Write("Enter City: ");
                obj.City = Console.ReadLine();
                Console.Write("Enter State: ");
                obj.State = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                obj.Zip = Console.ReadLine();

                //verification for phone number 
                while (true)
                {
                    Console.Write("Enter Phone Number: ");
                    string phNo = Console.ReadLine();
                    if (phNo.Length == 10)
                    {
                        obj.PhoneNumber = phNo;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Phone Number, It should Contains 10 digits");
                    }
                }
                //verification for email id
                while (true)
                {
                    Console.Write("Enter Email-id: ");
                    string emailId = Console.ReadLine();
                    if (emailId.Contains("@"))
                    {
                        obj.Email = emailId;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Email Id,It should Contains @ ");
                    }
                }
                //
                objcontact.Add(obj);
                Console.WriteLine("***************************************");

                numOfContacts--;
            }
            //adding into address book dictionary
            AddressBookDictionary.Add(addressBookName, objcontact);
            Console.WriteLine("**************Successfully Added****************");
        }

        //method for view Contacts
        public void ViewContacts()
        {
            if (AddressBookDictionary.Count > 0)
            {
                //printing the values in address book
                foreach (KeyValuePair<string, List<Contact>> element in AddressBookDictionary)
                {
                    Console.WriteLine($"******************{element.Key}*********************");
                    foreach (var obj in element.Value)
                    {
                        PrintValues(obj);
                        Console.WriteLine("*******************************************************");
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }

        //Printing values
        public void PrintValues(Contact x)
        {
            Console.WriteLine($"First Name : {x.FirstName}");
            Console.WriteLine($"Last Name : {x.LastName}");
            Console.WriteLine($"Address : {x.Address}");
            Console.WriteLine($"City : {x.City}");
            Console.WriteLine($"State : {x.State}");
            Console.WriteLine($"Zip Code: {x.Zip}");
            Console.WriteLine($"Phone Number: {x.PhoneNumber}");
            Console.WriteLine($"Email: {x.Email}");
        }

        //method for editing details
        public void EditDetails()
        {
            int f;//flag variable
            if (objcontact.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var x in objcontact)
                {
                    if (editName.ToLower() == x.FirstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.FirstName = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.LastName = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.Address = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.City = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.State = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.Zip = Console.ReadLine();
                                    Console.WriteLine("***************MODIFIED****************");
                                    break;
                                case 7:
                                    //validation for phone number
                                    while (true)
                                    {
                                        Console.Write("Enter new Phone Number: ");
                                        string phNo = Console.ReadLine();
                                        if (phNo.Length == 10)
                                        {
                                            x.PhoneNumber = phNo;
                                            Console.WriteLine("***************MODIFIED****************");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                                        }
                                    }
                                    break;
                                case 8:
                                    //validation for email id
                                    while (true)
                                    {
                                        Console.Write("Enter new Email-id: ");
                                        string emailId = Console.ReadLine();
                                        if (emailId.Contains("@"))
                                        {
                                            x.Email = emailId;
                                            Console.WriteLine("***************MODIFIED****************");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                                        }
                                    }
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Exited");
                                    f = 1;
                                    break;

                            }
                            if (f == 1)
                            {
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

        //method for deleting conatcts
        public void DeleteDetails()
        {
            int f = 0;
            if (objcontact.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in objcontact)
                {
                    if (deleteName.ToLower() == x.FirstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("***************DELETED****************");
                        Console.WriteLine($"You have deleted {x.FirstName} contact");
                        objcontact.Remove(x);
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





