using System;
namespace MoodAnalyserProject
{
	public class MoodAnalyser
	{
		public string message;
		public MoodAnalyser(string message)
		{
			this.message = message;
		}

		public string AnalyseMood()
		{
			if (message.ToLower().Contains("happy"))
			{
				return "happy";
				Console.WriteLine("happy");
			}
			else
			{
				return "sad";
                Console.WriteLine("sad");
            }
		}
	}
}

