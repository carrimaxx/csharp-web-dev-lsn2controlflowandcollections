using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and IDs
            do
            {
                Console.WriteLine("Student Name: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    int newID = int.Parse(input);
                    students.Add(newID, newStudent);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"Student ID: {student.Key}, Student name: {student.Value}");
            }
        }
    }
}
