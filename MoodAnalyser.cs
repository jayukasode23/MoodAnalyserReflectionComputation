using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserComputation
{
    public class MoodAnalyser
    {
        //Analysing the mood by passing happy Or sad.
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        public static void Main(string[] args)
        {

        }

    }
}

