using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    static class Report
    {
        /// <summary>
        /// Handles the reporting of Analyse
        /// </summary>
        /// <param name="data">Text analysis data</param>
        public static void OutputConsole(List<int> data)
        {
            //Assuming that the input comes from Analyse.AnalyseText()
            Console.WriteLine($"Number of sentences: {data[0]}");
            Console.WriteLine($"Number of vowels: {data[1]}");
            Console.WriteLine($"Number of consonants: {data[2]}");
            Console.WriteLine($"Number of upper case characters: {data[3]}");
            Console.WriteLine($"Number of lower case characters: {data[4]}");
        }


        /// <summary>
        /// Handles the reporting of Analyse
        /// </summary>
        /// <param name="data">Letter frequency data</param>
        public static void OutputConsole(Dictionary<char, int> data)
        {
            foreach (var letterFrequency in data.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{letterFrequency.Key} is used {letterFrequency.Value} times.");
            }

        }
    }
}
