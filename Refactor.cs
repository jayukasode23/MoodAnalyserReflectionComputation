using MoodAnalyserComputation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Refactor
    {
        [TestClass]
        public class TestCase2
        {
            //TC1.2-Here we check the Given condition " I am in sad mood should return sad".
            [TestMethod]
            public void GivenIAmInSadMoodShouldReturnSad()
            {
                //Arrange
                string message = "I am in Sad mood ";
                string expected = "Sad";
                MoodAnalyser moodAnalyze = new MoodAnalyser();

                //Act 
                string mood = moodAnalyze.AnalyseMood(message);


                //Assert
                Assert.AreEqual(expected, mood);

            }



            // TC1.2-Here we check the Given condition " I am in Any mood should return Happy".
            [TestMethod]
            public void GivenIAmInAnyMoodShouldReturnHappy()
            {
                //Arrange
                string message = "I am in any mood ";
                string expected = "Happy";
                MoodAnalyser moodAnalyze = new MoodAnalyser();

                //Act 
                string mood = moodAnalyze.AnalyseMood(message);


                //Assert
                Assert.AreEqual(expected, mood);

            }

        }
    }
}
