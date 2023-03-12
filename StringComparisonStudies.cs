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
            // NOTE: System.StringComparison enumerator specifies the culture, case and sort rules to be used by certain overloads of the Compare() and Equals() methods.
            Console.WriteLine(doom.Contains("john romero S2", StringComparison.OrdinalIgnoreCase));

            // StartsWith() verify if the string starts with determinate text
            Console.WriteLine(divinity.StartsWith("La")); // return true
            Console.WriteLine(doom.StartsWith("Romero")); // return false
            // EndsWith() do the same, but to the end
            Console.WriteLine(counterStrike.EndsWith("e", StringComparison.OrdinalIgnoreCase)); // return true
            Console.WriteLine(doom.EndsWith(")", StringComparison.OrdinalIgnoreCase)); // return true
            Console.WriteLine(halfLife.EndsWith("v")); // return false
        }
    }
}