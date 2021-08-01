using System;
using System.Collections.Generic;
using System.Text;

namespace AddressbookProgram
{
   public class Delete
    {

        public void DeletetheName()
        {
            if (AddAndRetrieveContact.AddressBook.Count > 0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var item in AddAndRetrieveContact.AddressBook)
                {
                    if (deleteName.ToLower() == item.FirstName.ToLower())
                    {
                        AddAndRetrieveContact.AddressBook.Remove(item);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}

   
