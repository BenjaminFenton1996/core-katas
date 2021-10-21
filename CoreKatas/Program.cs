using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreKatas
{
    public class Program
    {
        static async Task Main(string[] args)
        {         
            await foreach (var text in AsynchronousStream.GetText())
            {
                Console.WriteLine(text);
            }

            Console.WriteLine();           
            AsynchronousVsSynchronous.AsyncVsSyncSpeedTest();

            Console.ReadLine();
        }       
    }
}