using System;
using System.Linq;

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
           
            string [] mins= new string[arrnumbers.Count(n => int.Parse(n) < 0)];
            int m = 0;
            bool flag = false;
            for (int i = 0; i < arrnumbers.Length; i++)
            {
                if (int.Parse(arrnumbers[i]+"") < 0)
                {
                    flag = true;
                    mins[m] += arrnumbers[i];
                    m++;
                }
            }
            string mm = string.Join(", ", mins);
            if (flag)
            {
                throw new Exception("Negatives Not Allowed: " + mm);
            }
            else
            {
                Array.ForEach(arrnumbers, i => {
                    if (int.Parse(i) <= 1000)
                    {
                        sum += int.Parse(i);
                    }
                });
                return sum;
            }
            
        }
    }
}