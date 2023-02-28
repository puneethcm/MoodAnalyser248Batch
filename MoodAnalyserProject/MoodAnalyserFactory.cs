using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserProject
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructor)
        {
            string pattern = "." + constructor + "$";
            bool result = Regex.IsMatch(className, pattern);
            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType, constructor);
                }
                catch (Exception ex)
                {
                    throw new MoodAnalyserException("Class Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_CLASS);
                }
            }
            else
            {
                throw new MoodAnalyserException("Class Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_CLASS);
            }
        }

        public static object CreateMoodAnalyseObject(string className, string constructor)
        {
            string pattern = "." + constructor + "$";
            bool result = Regex.IsMatch(className, pattern);
            if (result)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType, constructor);
                }
                catch (Exception ex)
                {
                    throw new MoodAnalyserException("Class Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_CLASS);
                }
            }
            else
            {
                throw new MoodAnalyserException("Constructor is Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_METHOD);
            }
        }
    }
}

