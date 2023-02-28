using System.Reflection;
using MoodAnalyserProject;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Analyser Project");
        ////Console.WriteLine("Enter the mood you are in : ");
        ////string message = Console.ReadLine();
        //MoodAnalyser moodAnalyser = new MoodAnalyser("");
        //Console.WriteLine(moodAnalyser.AnalyseMood());

        //TestExceptionTypes.TestNullReferenceException("Kavitha");
        Console.ReadLine();
    }

    public static void TestReflection()
    {
        string path = "";
        Assembly assembly = Assembly.LoadFrom(path);
        Type[] types = assembly.GetTypes();
        foreach(Type type in types)
        {
            Console.WriteLine(type.FullName);
        }
    }
}