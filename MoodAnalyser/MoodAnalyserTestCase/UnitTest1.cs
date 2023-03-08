using MoodAnalyser;
namespace MoodAnalyserTestCase
{
    public class Tests
    {


        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass("I am in Sad Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass("I am in Happy Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Happy", result);
        }
        [Test]
        public void GivenNullMood_WhenAnalized_ShouldReturnHappy()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass(null);
            string result = mood.AnalizeMood();
            Assert.AreEqual("Happy", result);
        }

    }
}
