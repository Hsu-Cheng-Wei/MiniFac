using System;

namespace MiniFac.Unexpected
{
    public class MiniException : Exception
    {
        public const string Title = "MiniFac";

        public static ArgumentNullException ArgumentNull(Type argType)
            => throw new ArgumentNullException($"{Title}: {argType.FullName}");

        public static InvalidOperationException UnExpectedOperatedArgument(Type classType, string argName, object argResult, object expectedResult)
            => throw new InvalidOperationException(
                $"{Title}: parameter:{argName} expected {expectedResult} but find {argResult} in class:{classType.FullName}");

        public static InvalidOperationException UnExpectedOperated(Type classType, string message)
            => throw new InvalidOperationException($"{Title}: In class: {classType.FullName} get the exception {message}");
    }
}
