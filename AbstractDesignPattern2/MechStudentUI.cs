using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class MechStudentUI : IStudent
    {
        public List<string> Courses()
        {
            return new List<string> { "MEE 101", "MEE 102" };
        }
    }
}