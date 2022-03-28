using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string ManualTextInput()
        {
            Console.Write("Input: ");
            text = Console.ReadLine() ?? "";
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
            }
            text = File.ReadAllText(fileName);
            return text;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
