
using MoodAnalyserComputation;

namespace UnitTest
{

    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyzer;


        //Here we check the Given condition " I am in sad mood should return sad".
        [TestMethod]
        public void Given_Condition_I_Am_In_Sad_Mood_Should_Return_Sad()
        {
            moodAnalyzer = new MoodAnalyser();
            string message = "I am in Sad mood ";

            //Arrange
            string expected = "Sad";
            //Act 
            string result = moodAnalyzer.AnalyseMood(message);
            Assert.AreEqual(expected, result);


            //Assert
            Assert.AreEqual("Sad", result);
        }
        [TestMethod]
        public void Given_Condition_I_Am_In_Any_Mood_Should_Return_Happy()
        {
            moodAnalyzer = new MoodAnalyser();
            string message = "I am in Any mood ";

            //Arrange
            string expected = "Happy";
            //Act 
            string result = moodAnalyzer.AnalyseMood(message);
            Assert.AreEqual(expected, result);
        }

    }
}
