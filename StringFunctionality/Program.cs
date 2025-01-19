/*/
* FILE : StringFunctionality.csproj
* PROJECT : SENG1385 - Assignment 1 - Program 3
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025-1-16
* DESCRIPTION : Create a string and perform various operations (search, edit, compare, replace).
* Returns: Void 
/*/

namespace StringFunctionality
{
    /// <class> Program </class>
    /// <summary>
    /// Class to handle given strings and required adjustments
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            //Predefined Variables
            string phrase = "Here's a sentence that Brad wrote and hopefully it will do what Norbert wants it to do.";
            string toReplace = "it will do what Norbert wants it to do";
            string replacement = "Norbert will give me 100%";

            //Logic Method Processes
            string phraseAllCaps = CapitalizePhrase(phrase);
            int firstCharacterIndex = FindFirstCharIndex(phrase, 'B');
            string editedPhrase = FindAndReplaceString(phrase, toReplace, replacement);

            //Output to Screen to Demonstrate Accuracy
            Console.WriteLine("The beginning string is recorded to be:");
            Console.WriteLine(phrase);
            Console.WriteLine("When changed to all upper case, the phrase becomes: \n" + phraseAllCaps);
            Console.WriteLine("\nWhen searching for the letter 'B', it's zero-based index in the string is " + firstCharacterIndex);
            Console.WriteLine("\nWhen replacing the subset string \"it will do what Norbert wants it to do\", the edited string becomes");
            Console.WriteLine("\n\"" + editedPhrase + "\"");
        }

        /// <method> CapitalizePhrase </method>
        /// <summary> Takes a given string and converts all letters to uppercase. </summary>
        /// <param name="sentence"> Originally given sentence, with mixed case, characters, and punctuation. </param>
        /// <returns> phraseCaps : Original string in all capital letters. </returns>
        static string CapitalizePhrase(string sentence)
        {
            string phraseCaps = sentence.ToUpper();
            return phraseCaps;
        }

        /// <method> FindFirstCharacter </method> 
        /// <summary> Takes a given string and character and finds the first occurence
        ///     of that character within the string, if any.  </summary>
        /// <param name="sentence"> Given string </param>
        /// <param name="letter"> Character to search </param>
        /// <returns> charIndex : zero-based string index of first occurence of character, -1 if none found. </returns>
        static int FindFirstCharIndex(string sentence, char letter)
        {
            int charIndex = sentence.IndexOf(letter);
            return charIndex;
        }

        /// <method> FindAndReplaceString </method>
        /// <summary> Takes a given string and searches it for any occurences of a given substring
        ///     If occurences are found, replaces them with a given replacement substring. </summary>
        /// <param name="wholePhrase"> Entire sentence to search through </param>
        /// <param name="toRemove"> Substring to be searched for a replaced </param>
        /// <param name="replacement"> Substring to replace removed substring occurences </param>
        /// <returns> editedPhrase : Phrase with all required adjustments and replacements complete. </returns>
        static string FindAndReplaceString(string wholePhrase, string toRemove, string replacement)
        {
            string editedPhrase = wholePhrase.Replace(toRemove, replacement);
            return editedPhrase;
        }
    }
}
