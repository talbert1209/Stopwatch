using System;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            var stopWatch = new StopWatch();

            Console.WriteLine(@"Enter 'start' to start the watch, 'stop' to stop the watch, 'clear' to clear the watch and 'end' to end the program");

            while (stopWatch.IsStopWatchOn())
            {
                var userInput = Console.ReadLine()?.ToLower();

                switch (userInput)
                {
                    case "start":
                        stopWatch.StartTheWatch();
                        break;
                    case "stop":
                        stopWatch.StopTheWatch();
                        break;
                    case "clear":
                        stopWatch.ClearTheWatch();
                        break;
                    case "end":
                        stopWatch.End();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command!");
                        break;
                }
            }
        }
    }
}
