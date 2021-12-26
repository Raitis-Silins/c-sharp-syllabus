using System;

namespace Hierarchy
{
    class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id, double gpa)
            : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}, home address {_address}. persons ID: {_id}, GPA IS {_gpa}");
        }
    }
}