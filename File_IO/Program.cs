using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File_IO problem");
            while(true)
            {
                Console.WriteLine("---------------------------------------------\nPlease Select Below Given Options\n1.FileExists\n2.ReadAlllines\n3.CopyMethod\n4.DeleteFile\n5.ReadFromStreamReader\n6.WritUsingStreamWriter");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        FileIO.FileExist();
                        break;
                    case 2:
                        FileIO.ReadAllLines();
                        break;
                    case 3:
                        FileIO.FileCopy();
                        break;
                    case 4:
                        FileIO.DeleteFile();
                        break;
                    case 5:
                        FileIO.ReadFromStreamReader();
                        break;
                    case 6:
                        FileIO.WritUsingStreamWriter();
                        break;
                        default:
                        Console.WriteLine("\nPlease Select Free-Error Options");
                        break;
                }
            }
        }
    }
}