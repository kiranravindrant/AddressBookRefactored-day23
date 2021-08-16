using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Collections;


namespace AddressbookProgram
{
    public class ToJson
    {
        public static void JsonWrite()      
        {
            string strResultJson = JsonConvert.SerializeObject(MultipleAddressBook.AddressBookDictionary);  //passing dictionary to serialize oject func
            File.WriteAllText(@"AddressBook.json", strResultJson);
            Console.WriteLine("Stored");

        
        }
   
        public static void ReadJson()
        {
            string ContentJson = File.ReadAllText(@"AddressBook.json");
            var result = JsonConvert.DeserializeObject<IDictionary>(ContentJson);
           
            foreach (DictionaryEntry entry  in result)
            {

                Console.WriteLine(entry.Key+" : "+ entry.Value);    
            }
        
        }
        
    
    }

   
}
