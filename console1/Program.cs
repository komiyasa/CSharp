using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace console1
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task 1 Starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 Finish");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 Starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 Finish");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finish All Task. Press a any key to end.");
            Console.ReadKey();
        }
    }
}
