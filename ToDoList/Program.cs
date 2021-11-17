using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoFromPath = new List<string>();
            string toDoFilePath = @"C:\Users\opilane\samples\Titpe21\ToDoList.txt";
            toDoFromPath = File.ReadAllLines(toDoFilePath).ToList();

            foreach(string task in toDoFromPath)
            {
                Console.WriteLine(task);
            }

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would You Like To Add Task? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter a task");
                    string userTask = Console.ReadLine();
                    toDoFromPath.Add(userTask);
                    Console.WriteLine($"Task {userTask} added.");
                }else                
                {
                    Console.WriteLine("Take Care");
                    loopActive = false;
                }



            }
            File.WriteAllLines(toDoFilePath, toDoFromPath.ToArray());



        }
    }
}
