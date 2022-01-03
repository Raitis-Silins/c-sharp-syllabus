using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name)
        {
            return !NameExists(name) ? null : _data[name];
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            if (NameExists(name))
            {
                _data[name] += number;

            }
            else
            {
                _data.Add(name, number);
            }
        }

        private bool NameExists(string name)
        {
            return _data.ContainsKey(name);
        }
    }
}