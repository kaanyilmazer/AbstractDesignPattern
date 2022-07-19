using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class MedStudentUI : IStudent
    {
        public List<string> Courses()
        {
            return new List<string> { "SRG 101", "SRG 102" };
        }
    }
    }