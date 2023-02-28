using System;
namespace MoodAnalyserProject
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public ExceptionType exceptionType;

        public MoodAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}

