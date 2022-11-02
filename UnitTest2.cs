using MoodAnalyserComputation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public  class UnitTest2
    {
        Refactor1 refactor1;
    [TestMethod]
        public void Given_Condition_I_Am_In_Sad_Mood_Should_Return_Sad()
        {
            string message = "I Am In Sad Mood";
             refactor1 = new Refactor1(message);
            string expected = "Sad";
            string result = refactor1.AnalyseMood();
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Given_Condition_I_Am_In_Happy_Mood_Should_Return_Happy()
        {
            string message = "I Am In Happy Mood";
            refactor1 = new Refactor1(message);
            string expected = "Happy";
            string result = refactor1.AnalyseMood();
            Assert.AreEqual(expected, result);

        }
    }
    
}
