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
        Assert.AreEqual(expected, actual);
    }
    [DataRow("happy", null)]
    public void Given_NullMessage_Should_Return_UserMood(string message, string expected)
    {
        //arrange
        //message = " I am in happy mood";
        //expected = "happy";

        MoodAnalyser mood = new MoodAnalyser(message);

        //act
        string actual = mood.AnalyseMood();
        //assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow (null, "Message is null")]
    public void Given_CustomNullMessage_Should_Return_UserMood(string message, string expected)
    {
        //str
        try
        {
            //arrange
            //message = " I am in happy mood";
            //expected = "happy";

            MoodAnalyser mood = new MoodAnalyser(message);

            //act
            string actual = mood.AnalyseMood();
        }
        catch (CustomMoodAnalyserException ex)
        {
            //assert
            Assert.AreEqual(expected, ex.Message);
        }
    }
    [TestMethod]
    [DataRow("", "Message is empty")]
    public void Given_CustomEmptyMessage_Should_Return_UserMood(string message, string expected)
    {
        //str
        try
        {
            //arrange
            //message = " I am in happy mood";
            //expected = "happy";

            MoodAnalyser mood = new MoodAnalyser(message);

            //act
            string actual = mood.AnalyseMood();
        }
        catch (CustomMoodAnalyserException ex)
        {
            //assert
            Assert.AreEqual(expected, ex.Message);
        }
    }
}
