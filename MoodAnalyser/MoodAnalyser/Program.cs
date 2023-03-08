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
            MoodAnalyserClass mood = new MoodAnalyserClass(null);
            Console.WriteLine(mood.AnalizeMood());
            Console.ReadLine();
        }
    }
}