using MoodAnalyser;
namespace MoodAnalyserTestCase
{
    public class Tests
    {
        MoodAnalyserClass mood = new MoodAnalyserClass("I am in Sad Mood");

        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }

    }
}