using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;

namespace AbstractDesignPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent student = null;
            StudentFactory studentFactory = null;
            List<string> courses = null;

            //create a UI student factory by passing the factory type as UI
            studentFactory = StudentFactory.CreateStudentFactory("UI");
            Console.WriteLine("Student School: " + studentFactory.GetType().Name);

            // get bio student by passing the student type. 
            student = studentFactory.GetStudent("Med");
            Console.WriteLine("Student Dept: " + student.GetType().Name);
            courses = student.Courses();
            foreach (var item in courses)
            {
                Console.WriteLine("Course code: " + item);
            }
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }
    }
}

