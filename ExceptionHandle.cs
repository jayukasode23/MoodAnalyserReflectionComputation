using MoodAnalyserComputation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class HandleException
    {
        //UC2 Handle Exception If User Provides Invalid Mood".
        [TestMethod]
        public void Handle_Exception_If_User_Provides_Invalid_Mood()
        {
            try
            {
                //Arrange
                string message = "Null";

                //referance
                MoodAnalyser moodAnalyze = new MoodAnalyser();

                //Act 
                string result = moodAnalyze.AnalyseMood(message);
            }

            catch (NullReferenceException e)
            {
                //Assert

                Assert.AreEqual("mood null", e.Message);
            }

        }

        [TestMethod]
        //Handle Exception If User Provides Happy Mood"
        public void Exception_If_User_Provides_Happy_Mood()
        {
            try
            {
                //Arrange
                string message = "I Am In Happy Mood";

                //referance
                MoodAnalyser moodAnalyze = new MoodAnalyser();

                //Act 
                string result = moodAnalyze.AnalyseMood(message);
            }

            catch (NullReferenceException e)
            {
                //Assert

                Assert.AreEqual("Happy", e.Message);
            }

        }

    }
}