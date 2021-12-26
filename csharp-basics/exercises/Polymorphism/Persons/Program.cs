using Hierarchy;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Gregorijs", "Bumbieris", "Melnavas fermas", 111, 56.3);
            var employee = new Employee("Vladislavs", "Cepurnieks-Goppers", "zimbabwe", 1, "zāģeris");

            student.Display();
            employee.Display();
        }
    }
}