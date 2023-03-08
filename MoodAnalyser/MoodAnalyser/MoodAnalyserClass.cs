using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnlyseException;

namespace MoodAnalyser
{
    public class MoodAnalizerClass
    {
        string message;
        public MoodAnalizerClass()
        {
            message = null;
        }
        public MoodAnalizerClass(string message)
        {
            this.message = message;
        }
        public string AnalizeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                    throw new MoodAnlyseException(MoodAnlyseExceptionType.EmptyMood, "Please do not Enter the empty Input");
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
