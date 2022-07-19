using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public abstract class StudentFactory
    {
        public abstract IStudent GetStudent(string studentDept);

        public static StudentFactory CreateStudentFactory(string studentSch)
        {
            if (studentSch.Equals("UI"))
                return new UIStudentFactory();
            else
                return new FutaStudentFactory();
        }
    }
}