using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserComputation
{
    public class Refactor1
    {
        public string message;
        public Refactor1(string message)
        {
            this.message = message;
        }
        //Analysing the mood by passing happy Or sad.
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
