using Hierarchy;
using System;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
            : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}, home address {_address}. persons ID: {_id}, and the title is {_jobTitle}");
        }
    }
}
