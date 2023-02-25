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
			try
			{
                		if (message.ToLower().Contains("happy"))
                		{
                    			return "happy";
                		}
				else
				{
					return "sad";
				}
			}
			catch(NullReferenceException ex)
			{
				Console.WriteLine(ex.Message);
				return "happy";
			}
		}
	}
}

