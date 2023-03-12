using System;

namespace Strings
{
    class StringComparisonStudies
    {
        public StringComparisonStudies()
        {
            Console.Clear();

            string halfLife = "Valve";
            string counterStrike = "Valve";
            string divinity = "Larian";
            string doom = "Id Software (John Romero s2)";

            // CompareTo() returns an integer, so its important to be aware of your use.
            // Returns 0 when the value exit and 1 when not exist
            Console.WriteLine(halfLife.CompareTo("Valve")); // return 0
            Console.WriteLine(halfLife.CompareTo("Larian")); // return 1

            // Contains() is a case sensitive method than returns an boolean, and may be more useful in most cases
            Console.WriteLine(doom.Contains("Valve")); // return false
            Console.WriteLine(doom.Contains("John Romero s2")); // return true
            //The case sensitive property may be ignored
            Console.WriteLine(doom.Contains("john romero S2", StringComparison.OrdinalIgnoreCase));


        }
    }
}