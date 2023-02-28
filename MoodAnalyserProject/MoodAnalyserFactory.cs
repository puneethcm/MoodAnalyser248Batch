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

        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                try
                {
                    if (type.Name.Equals(constructorName))
                    {
                        ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                        object instance = ctor.Invoke(new object[] { message });
                        return instance;
                    }
                    else
                    {
                        throw new MoodAnalyserException("Constructor is Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_METHOD);
                    }
                }
                catch (Exception ex)
                {
                    throw new MoodAnalyserException("Constructor is Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_METHOD);
                }
            }
            else
            {
                throw new MoodAnalyserException("Class Not Found", MoodAnalyserException.ExceptionType.NO_SUCH_CLASS);
            }
        }
    }
}

