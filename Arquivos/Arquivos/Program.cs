using System;
using System.IO;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\windows\temp\file1.txt";
            string targetPath = @"C:\windows\temp\file2.txt";

            try { 
            using (FileStream fs = new(sourcePath, FileMode.Open))
            {
                using (StreamReader sr = new(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
                //FileInfo fileInfo = new (sourcePath);
                //FileInfo fileInfo = new (sourcePath);
                //fileInfo.CopyTo(targetPath);

                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach(string line in lines)

            } catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
