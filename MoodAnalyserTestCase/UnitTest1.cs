using MoodAnalyserProject;

namespace MoodAnalyserTestCase;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow("happy", "I am in happy mood")]
    [DataRow("sad", "I am in sad mood")]
    public void Given_Method_Should_Return_UserMood(string expected, string message)
    {
        //arrange
        //message = " I am in happy mood";
        //expected = "happy";

        MoodAnalyser mood = new MoodAnalyser(message);

        //act
        string actual = mood.AnalyseMood();

        //assert
        Assert.AreEqual(expected,actual);
    }
}
