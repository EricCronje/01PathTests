using System.IO;
using System;

namespace ConApp_Path
{
    class Program
    {
        static void Main(string[] args)
        {
			// abstract
            Console.WriteLine("Q: using the path as example c:\\Stagelist.txt - provide the following:");
            Console.WriteLine();
            Console.WriteLine("Specify path then");
            Console.WriteLine("1. Full path");
            Console.WriteLine("2. Extension of file");
            Console.WriteLine("3. Filename");
            Console.WriteLine("4. Filename no extension");
            Console.WriteLine("5. root");
			Console.WriteLine("6. get random file");
			Console.WriteLine("7. Change extension");
			Console.WriteLine("8. Show DirectorySeparatorChar");
			Console.WriteLine("9. GetTempFileName");
			Console.WriteLine("10. GetDirectoryName");			
            Console.WriteLine("Display the results ...");

            var path = "c:\\Stagelist.txt";
            var fullPath = Path.Combine(path);

            Console.WriteLine("A:");

			//Beta sadasdasd
			
            Console.ReadKey();

        }
    }
}
