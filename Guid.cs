using System;

namespace Strings
{
    class Guids
    {
        public Guids ()
        {
            //GUID - Global Unique Identifier
            Console.Clear();
            
            // Creating a Global Unique Identifier
            var id = Guid.NewGuid(); 

            var zero_guid = new Guid(); // we can instantiate guids that way but
            Console.WriteLine(zero_guid); // it will only generate 0's
            
            // Its possible to set your own hash, but
            // we have to handle with the format of 32 digits, 4 dashes 
            // with only Hexadecimal characters:
            // (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)
            id = new Guid("abcabcab-abcd-abcd-ffff-000000000000"); 
            Console.WriteLine(id.ToString().Substring(0, 8)); // get the first eight characters
            Console.WriteLine(id);

            var id2 = Guid.NewGuid();
            Console.WriteLine(id2);

            // we can use comparators
            if(id.CompareTo(id2) == 0) 
                Console.Write("You're crazy, ");

            // but it is not an string
            if(id.ToString().Contains(id2.ToString()))
                Console.WriteLine("very crazy");
        }
    }
}