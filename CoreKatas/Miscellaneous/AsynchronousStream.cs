using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreKatas
{
    public static class AsynchronousStream
    {       
        public static async IAsyncEnumerable<string> GetText()
        {
            //FizzBuzz
            Console.WriteLine("Asynchronous Stream FizzBuzz: ");
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(250);
                if (i % 2 == 0)
                {
                    yield return "Fizz";
                }
                else
                {
                    yield return "Buzz";
                }
            }
        }
    }
}
