using AbstractDesignPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDesignPattern2
{
    public class FutaStudentFactory : StudentFactory
    {
        public override IStudent GetStudent(string studentDept)
        {
            if (studentDept.Equals("Geo"))
                return new GeoStudentFuta();
            else if (studentDept.Equals("Bio"))
                return new BioStudentFuta();
            else if (studentDept.Equals("Chem"))
                return new ChemStudentFuta();
            else
                return null;
        }
    }
}