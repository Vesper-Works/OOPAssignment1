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
        public bool FromFile { get; private set; } //Encapsulation

        public string TextInputChoice() //Additional | Data Abstraction
        {
            bool successfulInput = false;
            while (!successfulInput)
            {
                successfulInput = true;
                Console.WriteLine("Enter input mode: (M)anual, (F)ile");
                string fullInput = Console.ReadLine() ?? ".";
                char inputMode = fullInput.ToUpper()[0];

                switch (inputMode)
                {
                    case 'M':
                        FromFile = false;
                        return ManualTextInput();
                    case 'F':
                        FromFile = true;
                        return InputFileNameTextInput();
                    default:
                        successfulInput = false;
                        break;
                }
            }
            return "ERROR";
        }

        private string InputFileNameTextInput() 
        {
            bool successfulInput = false;
            while (!successfulInput)
            {
                successfulInput = true;
                Console.Write("Enter file path: ");
                string filePath = Console.ReadLine() ?? "";
                try
                {
                    return FileTextInput(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    successfulInput = false;
                }
            }
            return "ERROR";
        }

        /// <summary>
        /// Gets text input from the keyboard
        /// </summary>
        /// <returns>User-inputted string</returns>
        public string ManualTextInput()
        {
            Console.Write("Input: ");
            text = Console.ReadLine() ?? "";
            return text;
        }

        /// <summary>
        /// Gets text input from a .txt file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>File-read string</returns>
        public string FileTextInput(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
            }
            text = File.ReadAllText(fileName);
            return text;
        }

        public override string ToString() //Additional 
        {
            return text;
        }
    }
}
