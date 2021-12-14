using System;

namespace Exercise5
{
    class Date
    {
        private int _month;

        private int _day;

        private int _year;

        public Date(int month, int day, int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{_month}/{_day}/{_year}");
        }
    }
}
