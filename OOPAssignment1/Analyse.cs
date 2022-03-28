using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            List<int> values = new List<int>();

            //List initialisation
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            char[] endOfSentance = { '.', '!', '?' };

            values[0] = input.Split(endOfSentance).Length - 1;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            values[1] = input.ToLower().Count(c => vowels.Contains(c));

            values[2] = input.ToLower().Count(c => !vowels.Contains(c) && char.IsLetter(c));

            values[3] = input.Count(c => c >= 65 && c <= 90 || c >= 192 && c <= 221);

            values[4] = input.Count(c => c >= 97 && c <= 122 || c >= 223 && c <= 225);


            return values;
        }

        public Dictionary<char, int> LetterFrequency(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!char.IsLetter(letter)) { continue; }
                result[letter] = result.ContainsKey(letter) ? result[letter] + 1 : 1;
            }

            return result;
        }
    }
}
