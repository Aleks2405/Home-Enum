using System;

namespace Home_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerWWW worker = new WorkerWWW();
            TeamleaderWWW teamleader = new TeamleaderWWW();

            IPart[] s = {
                Home.Basement ,
                Home.Walls,
                 Home.Walls,
                  Home.Walls,
                   Home.Walls,
                   Home.Door,
                   Home.Window,
                   Home.Window,
                   Home.Window,
                   Home.Window,
                   Home.Roof
            };


            foreach (IPart a in s)
            {
                Console.WriteLine($"{a.Name}");

            }
            Console.WriteLine(worker.Work(s[^1]));
            Console.WriteLine(teamleader.Work(s[^1]));
        }
    }
}
