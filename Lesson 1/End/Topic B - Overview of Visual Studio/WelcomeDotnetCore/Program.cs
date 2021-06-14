using System;

namespace WelcomeDotnetCore
{
    class Program 
    {
        static void Main(string[] args)
        {
            string firstStatement = "Hello World!";
            string secondStatement = "Welcome, .NET Core!";

            PrintStatements(firstStatement, secondStatement);
            
        }

        private static void PrintStatements(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }
}
