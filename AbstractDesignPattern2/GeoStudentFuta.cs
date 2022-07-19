using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class GeoStudentFuta : IStudent
    {
        public List<string> Courses()
        {
            return new List<string> { "Geo 101", "Chem 201" };
        }
    }
}