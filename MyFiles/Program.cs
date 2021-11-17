using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullfilePath = @"C:\Users\opilane\samples\Titpe21";
            string filePath = fullfilePath + @"\myFiles.txt";
            string[] dataFormFile = File.ReadAllLines(filePath);

            for (int i = 0; i < dataFormFile.Length; i++)
            {
                dataFormFile[i] = dataFormFile[i].Replace('4', 'a');
                dataFormFile[i] = dataFormFile[i].Replace('3', 'e');
                dataFormFile[i] = dataFormFile[i].Replace('0', 'o');
                dataFormFile[i] = dataFormFile[i].Replace('1', 'i');
                File.WriteAllLines(filePath, dataFormFile);
                   

            }
            foreach (string line in dataFormFile)
            {
                File.Create($@"{fullfilePath}\{line}.txt");
            }
            

            

        }
    }
}
