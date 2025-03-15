using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NUnitTestsPart2Lecture2
{
    internal class ParallelTasks
    {

        public static void RunParallelTasks()
        {
            /*  Parallel.Invoke(
                  () => ReadAFile(),
                  () => SortAnArray(),
                  () => SumOfNumbers()
              ); */

            Thread thread1 = new Thread(() => ReadAFile());
            Thread thread2 = new Thread(() => SortAnArray());
            Thread thread3 = new Thread(() => SumOfNumbers());

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            //thread2.Join();

            Console.WriteLine("All tasks completed.");
        }
        static void ReadAFile()
        {
            Console.WriteLine("Task 1 started");

            // Create a string array with the lines of text
            string[] lines = { "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            Console.WriteLine("Task 1 completed");
        }
        static void SortAnArray()
        {
            Console.WriteLine("Task 2 started");

            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Array sorted successfully");
            Console.WriteLine("Task 2 completed");
        }
        static void SumOfNumbers()
        {
            Console.WriteLine("Task 3 started");

            int sum = 0;
            for (int index = 1; index <= 100; index++)
            {
                sum += index;
            }
            Console.WriteLine("Sum of numbers from 1 to 100 is: " + sum);
            Console.WriteLine("Task 3 completed");
        }

    }
}
