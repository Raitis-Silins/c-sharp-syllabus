namespace Exercise_1
{
    public class Check15
    {
        public bool CheckIntegers(int num1, int num2)
        {
            return num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15;
        }
    }
}