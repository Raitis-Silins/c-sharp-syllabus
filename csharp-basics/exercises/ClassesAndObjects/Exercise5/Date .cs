using System;

namespace Exercise5
{
    class Date
    {
        private int _month { get; set; }

        private int _day { get; set; }

        private int _year { get; set; }

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
