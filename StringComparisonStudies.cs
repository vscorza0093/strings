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
            Console.WriteLine(halfLife.CompareTo("Valve")); // print 0
            Console.WriteLine(halfLife.CompareTo("Larian")); // print 1

            // Contains() is a case sensitive method than returns a boolean, and may be more useful in most cases
            Console.WriteLine(doom.Contains("Valve")); // print false
            Console.WriteLine(doom.Contains("John Romero s2")); // print true

            //The case sensitive property may be ignored
            // NOTE: System.StringComparison enumerator specifies the culture, case and sort rules to be used by certain overloads of the Compare() and Equals() methods.
            Console.WriteLine(doom.Contains("john romero S2", StringComparison.OrdinalIgnoreCase));

            // StartsWith() verify if the string starts with determinate text
            Console.WriteLine(divinity.StartsWith("La")); // print true
            Console.WriteLine(doom.StartsWith("Romero")); // print false
            // EndsWith() do the same, but to the end
            Console.WriteLine(counterStrike.EndsWith("e", StringComparison.OrdinalIgnoreCase)); // print true
            Console.WriteLine(doom.EndsWith(")", StringComparison.OrdinalIgnoreCase)); // print true
            Console.WriteLine(halfLife.EndsWith("v")); // print false

            // Equals() method isnt exclusive to strings, it returns a boolean, but the compared string must be identical
            Console.WriteLine(halfLife.Equals("valve", StringComparison.OrdinalIgnoreCase)); // print true
            Console.WriteLine(doom.Equals("Id software", StringComparison.OrdinalIgnoreCase)); // print false
            Console.WriteLine(doom.Equals("Id Software (John Romero s2)")); // print true

            // Additional Methods
            /*
            .ToLower() -> transform all the string in lower case
            .ToUpper() -> transform all the string in upper case
            .Insert(int startIndex, string value) insert a string or character in determinate string or list at determinate index valid position
            */
            Console.WriteLine(halfLife.Insert(halfLife.Length, " é foda")); // print "Valve é foda"
            Console.WriteLine(halfLife.Insert(halfLife.Length + 1, " é foda")); // Exception: Argument out of range. We could handle with length because 
            
        }
    }
}