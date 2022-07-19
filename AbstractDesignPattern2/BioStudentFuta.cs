using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class BioStudentFuta : IStudent
    {
        public List<string> Courses()
        {
            return new List<string> { "Bio 101", "Bio 201" };
        }
    }
}