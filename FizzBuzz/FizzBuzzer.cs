using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
                
            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}