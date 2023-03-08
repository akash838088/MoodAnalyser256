using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MoodAnalysrClass mood = new MoodAnalyserClass("");
            //Console.WriteLine(mood.AnalizeMood()); 
            MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalizer.MoodAnalizerClass", "MoodAnalizerClass");

            Console.ReadLine();
        }
    }
}
