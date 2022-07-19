using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class ChemStudentFuta : IStudent
    {
        public List<string> Courses()
        {
            return new List<string> { "Chem 101", "Chem 201" };
        }
    }
} 
