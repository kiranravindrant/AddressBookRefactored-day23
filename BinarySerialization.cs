using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace AddressbookProgram
{ [Serializable]
    public class BinarySerialization
    {

         public static void SerializeToBinary()
         {       
                string path = @"C:\Users\LENOVO\source\repos\Addressbook\inbinary.txt";
                FileStream obstream = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter obformatter = new BinaryFormatter();

            obformatter.Serialize(obstream,MultipleAddressBook.AddressBookDictionary);
            obstream.Close();
            Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.WriteLine("File serialized and saved in path :"+path);
            Console.ReadLine();

         }













     }

}
