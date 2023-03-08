using MoodAnalyser;
namespace MoodAnalyserTestCase
{
    public class Tests
    {
        MoodAnalyserClass mood = new MoodAnalyserClass();

        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            string result = mood.AnalizeMood("I am in Sad Mood");
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            string result = mood.AnalizeMood("I am in Happy Mood");
            Assert.AreEqual("Happy", result);
        }

    }
}