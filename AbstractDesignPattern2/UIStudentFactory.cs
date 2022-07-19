using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class UIStudentFactory : StudentFactory
    {
        public override IStudent GetStudent(string studentDept)
        {
            if (studentDept.Equals("Med"))
                return new MedStudentUI();
            else if (studentDept.Equals("Mech"))
                return new MechStudentUI();
            else
                return null;
        }
    }
}