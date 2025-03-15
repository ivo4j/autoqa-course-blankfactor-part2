using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestsPart2Lecture2
{
    internal class ThreadSafetyTest
    {
        private static int _counter = 0;
        private static readonly object _lock = new object();
        private const int NumThreads = 10;
        private const int IncrementsPerThread = 1000;

        public static void RunThreadSafetyTest()
        { 
            Thread[] threads = new Thread[NumThreads];

            // Create and start threads
            for (int index = 0; index < NumThreads; index++)
            {
                threads[index] = new Thread(IncrementCounterSafely);
                threads[index].Start();
            }

            // Wait for all threads to complete
            foreach (Thread t in threads)
            {
                t.Join();
            }

            // Expected value = NumThreads * IncrementsPerThread
            int expectedValue = NumThreads * IncrementsPerThread;
            Console.WriteLine($"Expected Counter: {expectedValue}");
            Console.WriteLine($"Actual Counter:   {_counter}");

            Console.WriteLine(_counter == expectedValue
                ? "✅ Thread safety test passed!"
                : "❌ Thread safety test failed!");
        }

        static void IncrementCounterSafely()
        {
            for (int index2 = 0; index2 < IncrementsPerThread; index2++)
            {
                lock (_lock)
                {
                    _counter++;
                }
            }
        }

    }
}
