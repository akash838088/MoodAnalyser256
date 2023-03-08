using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        string message;
        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public string AnalizeMood()
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Sad";

        }
    }
}