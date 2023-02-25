﻿using System;
namespace MoodAnalyserProject
{
	public class CustomMoodAnalyserException:Exception
	{
		public ExceptionTypes exceptionTypes;

		public enum ExceptionTypes
		{
			NULL_MOOD,
			EMPTY_MOOD
		}

		public CustomMoodAnalyserException(string message, ExceptionTypes exceptionTypes):base(message)
		{
			this.exceptionTypes = exceptionTypes;
		}
	}
}

