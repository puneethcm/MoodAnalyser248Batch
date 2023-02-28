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

    [TestMethod]
    [TestCategory("Reflection")]
    public void Given_Mood_Analyse_Class_Should_Return_Object()
    { 
        Object expected = new Object();
        object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");
        actual.Equals(expected);
    }

    [TestMethod]
    public void Improper_ClassName_Should_Return_Exception()
    {
        string expected = "Class Not Found";
        try
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");

        }
        catch (MoodAnalyserException exception)
        {
            Assert.AreEqual(expected, exception.Message);
        }
    }
    [TestMethod]
    public void Improper_ConstructorName_Should_Return_Exception()
    {

        string expectedMsg = "Constructor is Not Found";
        try
        {
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");

        }
        catch (MoodAnalyserException ex)
        {
            Assert.AreEqual(expectedMsg, ex.Message);
        }
    }
}
