using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_47_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = WritetoFile();
            
            while (!t1.Wait(100))
            {
                Console.WriteLine(".");
            }
        }

        static async Task WritetoFile()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "hellothere.txt")))
            {
                Console.WriteLine("Building...");
                for (int i = 0; i <= 1000; i++)
                {
                    await outputFile.WriteLineAsync(i.ToString());
                    Thread.Sleep(2);
                }
                
                Console.WriteLine("Construction complete!");
            }
        }
    }
}
