using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        /// <summary>
        /// Calculates and returns an analysis of the text
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers corresponding to text analysis</returns>
        public List<int> AnalyseText(string input, bool createFile)
        {
            List<int> values = new List<int>();

            //List initialisation
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }
            char[] endOfSentence = { '.', '!', '?' }; //Characters which indicate the end of a sentance. Ellipsis will create problems.

            values[0] = input.Split(endOfSentence).Length - 1; //Split text into sentances based on sentance ending punctuation.

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            values[1] = input.ToLower().Count(c => vowels.Contains(c)); //Counts the number of vowels.

            values[2] = input.ToLower().Count(c => !vowels.Contains(c) && char.IsLetter(c));  //Counts the number of consonants.

            values[3] = input.Count(c => c >= 65 && c <= 90 || c >= 192 && c <= 221); //Counts the number of upper case characters using character codes.

            values[4] = input.Count(c => c >= 97 && c <= 122 || c >= 223 && c <= 225); //Counts the number of lower case characters using character codes.

            if (createFile)
            {
                StreamWriter streamWriter = File.CreateText("LongWords.txt");
                foreach (string word in new String(input.Where(x => !char.IsPunctuation(x)).ToArray()).Split(' ').Where(x => x.Length > 7))
                {                
                    streamWriter.WriteLine(word);
                }
                streamWriter.Close();
            }

            return values;
        }

        public Dictionary<char, int> LetterFrequency(string input) //Additional 
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!char.IsLetter(letter)) { continue; }
                result[letter] = result.ContainsKey(letter) ? result[letter] + 1 : 1; //If the dictionary already contains the character, add the character, else increment by one.
            }

            return result;
        }
    }
}
