using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi. Enter your name below:");
            var teacher_name = Console.ReadLine();

            Console.WriteLine($"Hello, {teacher_name}! How are you today?");
        }
    }
}