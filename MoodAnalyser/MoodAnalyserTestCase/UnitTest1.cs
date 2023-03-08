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
        [Test]
        public void GivenNullMood_ThrowMoodAnalysisException_NullMessage()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass(null);
            try
            {
                string result = mood.AnalizeMood();
            }
            catch (MoodAnlyseException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_ThrowMoodAnalysisException_EmptyMessage()
        {
            MoodAnalyserClass mood = new MoodAnalyserClass("");
            try
            {
                string result = mood.AnalizeMood();
            }
            catch (MoodAnlyseException obj)
            {
                Assert.AreEqual("Please do not Enter the empty Input", obj.Message);
            }
        }
    }
}
