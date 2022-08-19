using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CoreKatas
{
    public static class AsynchronousVsSynchronous
    {
        public static async void AsyncVsSyncSpeedTest()
        {
            Console.WriteLine("Async vs Sync Speed Test: ");
            DoSynchronousTasks();
            Console.WriteLine();

            await Task.Run(() => DoAsynchronousTasks());
        }

        public static void DoSynchronousTasks()
        {
            var stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("1 - Sync");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("2 - Sync");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("3 - Sync");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("4 - Sync");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("5 - Sync");

            stopwatch.Stop();
            Console.WriteLine("Time elapsed (Sync): " + stopwatch.ElapsedTicks);
        }

        public static async Task DoAsynchronousTasks()
        {
            var stopwatch = Stopwatch.StartNew();
            var tasks = new List<Task<string>>()
            {
                ExampleAsynchronousTask(1),
                ExampleAsynchronousTask(2),
                ExampleAsynchronousTask(3),
                ExampleAsynchronousTask(4),
                ExampleAsynchronousTask(5)
            };

            await Task.WhenAll(tasks);
            foreach(var task in tasks)
            {
                Console.WriteLine(task.Result);
            }

            stopwatch.Stop();
            Console.WriteLine("Time elapsed (Async): " + stopwatch.ElapsedTicks);
        }

        public static async Task<string> ExampleAsynchronousTask(int i)
        {
            await Task.Delay(250);
            return i + " - Async";
        }
    }
}
