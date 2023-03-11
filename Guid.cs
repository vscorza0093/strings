using System;

namespace Strings
{
    class Guids
    {
        static void Main(string[] args)
        {
            //GUID - Global Unique Identifier
            Console.Clear();
            
            // Creating a Global Unique Identifier
            var id = Guid.NewGuid(); 

            var zero_guid = new Guid(); // we can instantiate guids that way but
            Console.WriteLine(zero_guid); // it will onlye generate 0's
            
            // Its possible to set your own hash, but
            // we have to handle with the format 32 digits, 4 dashes 
            // with only Hexadecimal characters
            // (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
            id = new Guid("abcabcab-abcd-abcd-ffff-000000000000"); 
            Console.WriteLine(id.ToString().Substring(0, 8)); // get the first eight characters
            Console.WriteLine(id);

            var id2 = Guid.NewGuid();
            Console.WriteLine(id2);

            if(id == id2) // we can use comparators
                Console.WriteLine("You're crazy");
        }
    }
}