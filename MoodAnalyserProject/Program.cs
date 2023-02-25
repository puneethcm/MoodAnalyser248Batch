using MoodAnalyserProject;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Analyser Project");
        Console.WriteLine("Enter the mood you are in : ");
        string message = Console.ReadLine();
        MoodAnalyser moodAnalyser = new MoodAnalyser(message);
        Console.WriteLine(moodAnalyser.AnalyseMood());
        Console.ReadLine();
    }
}