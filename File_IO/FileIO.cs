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
        public static void FileCopy()
        {
            string path = @"E:\Bridgelabz\File-IO\File_IO\TextFile1.txt";
            string copypath = @"E:\Bridgelabz\File-IO\File_IO\TextFileNew2.txt";
            File.Copy(path, copypath);
            Console.WriteLine("********Successfully copied***********");
        }
        public static void DeleteFile()
        {
            string copypath = @"E:\Bridgelabz\File-IO\File_IO\TextFileNew2.txt";
            File.Delete(copypath);
            Console.WriteLine("********Successfully Deleted***********");
        }
        public static void ReadFromStreamReader()
        {
            string path = @"E:\Bridgelabz\File-IO\File_IO\TextFile1.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s=sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
