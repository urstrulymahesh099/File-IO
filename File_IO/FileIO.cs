using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class FileIO
    {
        public static void FileExist()
        {
            string path = @"E:\Bridgelabz\File-IO\File_IO\TextFile1.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllLines()
        {
            string path = @"E:\Bridgelabz\File-IO\File_IO\TextFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        
    }
}
