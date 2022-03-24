using System;

namespace String_Calculator_Kata
{
    public class Calculator
    {
        public int add(String numbers)
        {
            int sum = 0;
            if (numbers == "")
            {
                return 0;
            }
            string[] arrnumbers = numbers.Split(',','\n');
            Array.ForEach(arrnumbers, i => sum += int.Parse(i));
            return sum;
        }
    }
}