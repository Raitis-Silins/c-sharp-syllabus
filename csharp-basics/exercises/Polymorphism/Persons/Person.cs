namespace Hierarchy
{
    abstract class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected string _address;
        protected int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public abstract void Display();
    }
}