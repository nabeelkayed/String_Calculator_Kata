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
            char delimiter = ','; 
            string NewNumbers = "";
            if (numbers[0] == '/')
            {
                delimiter= numbers[2];
                for (int i = 4; i < numbers.Length; i++)
                {
                    NewNumbers += numbers[i];
                }
            }
            else
            {
                NewNumbers = numbers;
            }
           
            string[] arrnumbers = NewNumbers.Split(delimiter,',','\n');
            Array.ForEach(arrnumbers, i => sum += int.Parse(i));
            return sum;
        }
    }
}