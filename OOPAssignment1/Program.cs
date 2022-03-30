//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            Input input = new Input();
            //input.FileTextInput("example.txt");
            input.TextInputChoice();

            Analyse analyse = new Analyse();
            Report.OutputConsole(analyse.AnalyseText(input.ToString(), input.FromFile));
            Report.OutputConsole(analyse.LetterFrequency(input.ToString()));
        }



    }
}
