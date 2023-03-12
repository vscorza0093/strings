using System;
using System.Text;

namespace Strings
{
    class StringStudies
    {
        public StringStudies()
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
            Console.WriteLine(halfLife.Insert(halfLife.Length, " é foda")); // Exception: Argument out of range. We could handle with length because 
            
            /*
            .Remove(int startIndex, int count) -> Remove the amount of characters, represented by int count, starting from the index represented by startIndex (inclusive)
            */
            Console.WriteLine(doom.Remove(5, 5)); // will remove "ftwar" and print Id Soe (John Romero s2)
            Console.WriteLine(doom.Remove(18, 5)); // will remove "Romero" and print Id Software (John s2)

            /*
            .Replace() -> Replace the first parameter by the second parameter. Its case sensitive
            */
            Console.WriteLine(divinity.Replace("a", "Original Sin")); // Larian turns into LOriginal SinriOriginal Sinn

            /*
            .Split() -> Return a array of strings, based on the provided string separator
            */

            var splitedString = doom.Split(" ");
            foreach(string text in splitedString)
                Console.WriteLine(text);

            /*
            .Substring(int startIndex, int length) -> Retrive a substring based on length integer number, starting from startIndex. 
            */
            var subString = doom.Substring(3, 8);
            Console.WriteLine(subString); // Print software

            /*
            .Trim() -> remove empty spaces from the ending and the beggining of an string
            */
            Console.WriteLine(doom.Trim());

            /*
            Strings are value objects, so the memory stores the data and not the reference (pointer) of the object
            */
            var quakeTxt = "Quake is cool";
            var doomTxt = quakeTxt;
            Console.WriteLine($"{quakeTxt}, {doomTxt}");
            doomTxt = "but Doom is better";
            Console.WriteLine($"{quakeTxt}, {doomTxt}");

            /*
            If we are trying to read an text file in one shoot and this text is too extensive, this may cause memory problems. So its nice to read line by line.

            So we could use @ to concat and dont ignore the text wrap:
            */

            var nonDynamicNewLine = @"Testing
                        a non dynamic
                        method
                        to create 
                        new lines
                    ";

            /*
            A better way is using StringBuilder()
            */
            var stringBuilderTest = new StringBuilder(); //using System.Text

            stringBuilderTest.Append("Test 1\n");
            stringBuilderTest.Append("Test 2\n");
            stringBuilderTest.Append("Test 3\n");
            stringBuilderTest.Append("Test 4\n");

            Console.WriteLine(stringBuilderTest); // Here we dont need to converto ToString() because Console.WriteLine already handle with it, but, in other cases we have to because StringBuilder() is a unique class.
        }
    }
}