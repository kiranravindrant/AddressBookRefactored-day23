﻿using System;

namespace AddressbookProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Program ");
            MultipleAddressBook objnew = new MultipleAddressBook();

            while (true)
            {
                Console.WriteLine("\n Enter your choice \n 1 for Adding Contacts \n 2 for viewing Address book" +
                    " \n 3 for editing the existing contact \n 4 for deleting contact\n 5 for  Search by city \n 6  Search by state  \n 7  Exit \n 8  Sort A->z");

                try
                {

                    int choice = int.Parse(Console.ReadLine());
                    




                    switch (choice)
                    {
                        case 1:
                            objnew.AddMember();


                            break;


                        case 2:
                            objnew.ViewContacts();

                            break;



                        case 3:
                            objnew.EditDetails();

                            break;

                        case 4:

                            objnew.DeleteDetails();
                            break;

                        case 5:
                            objnew.Searchbycity();
                            break;

                        case 6:
                            objnew.Searchbystate();
                            break;


                            
                        case 7:
                            Environment.Exit(0);
                            break;

                        case 8:
                            objnew.SortEntriesAlphabetically();
                               break;



                        default:
                            Console.WriteLine("Enter valid choice.");
                            break;


                    }


                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }





                

                
        }   }    
    }
}


        
    

