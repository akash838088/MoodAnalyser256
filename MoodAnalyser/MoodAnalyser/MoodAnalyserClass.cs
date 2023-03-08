using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnlyseException;

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
            try
            {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnlyseException(MoodAnlyseExceptionType.NullMood, "Please do not Enter the Null Input");
            }
        }
    }
}