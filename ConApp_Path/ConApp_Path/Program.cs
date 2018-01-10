using System.IO;
using System;

namespace ConApp_Path
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Q: using the path as example c:\\Stagelist.txt - provide the following:");
            Console.WriteLine();
            Console.WriteLine("Specify path then");
            Console.WriteLine("1. Full path");
            Console.WriteLine("2. Extention of file");
            Console.WriteLine("3. Filename");
            Console.WriteLine("4. Filename no extention");
            Console.WriteLine("5. root");
            Console.WriteLine("Display the results ...");

            var path = "c:\\Stagelist.txt";
            var fullPath = Path.Combine(path);

            Console.WriteLine("A:");
            Console.WriteLine
            (
            "1. Path: {0}\n2. FullPath: {1}\n3. Extention: {2}\n4. Filename with Extention: {3}\n5. Filename without Extention: {4}\n6. Root: {5}\n7. Random File or folder {6}\n8. Change extention {7}\n9. Separator {8}\n10. Temp file name {9}\n11. Get directory name: {10}"
            , path
            , Path.GetFullPath(fullPath)
            , Path.GetExtension(fullPath)
            ,Path.GetFileName(fullPath)
            ,Path.GetFileNameWithoutExtension(fullPath)
            ,Path.GetPathRoot(fullPath)
            ,Path.GetRandomFileName()
            ,Path.ChangeExtension(fullPath,"tft")
            , Path.DirectorySeparatorChar
            ,Path.GetTempFileName()
            ,Path.GetDirectoryName(fullPath)
            );

            Console.ReadKey();

        }
    }
}
