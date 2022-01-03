using System.Text.RegularExpressions;

namespace WordCount
{
    public class Calculate
    {
        private string _text;

        public Calculate(string text)
        {
            _text = text;
        }

        public int LinesInText()
        {
            return _text.Split('\n').Length;
        }

        public int WordsInText()
        {
            return Regex.Matches(_text, @"[A-Za-z]+").Count;
        }

        public int CharsInText()
        {
            return _text.Replace("\n", "").ToCharArray().Length;
        }
    }
}