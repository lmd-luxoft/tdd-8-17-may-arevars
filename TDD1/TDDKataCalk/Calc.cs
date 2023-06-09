﻿namespace TDDKataCalk;

public class Calc
{

    /// <summary>
    ///Create a simple String calculator with a method int Add(string numbers)The method can take 0, 1 or 2 numbers, and will return their sum(for an empty string it will return 0) for example “” or “1” or “1, 2”
    ///Start with the simplest test case of an empty string and move to 1 and 2 numbers
    ///Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
    ///Remember to refactor after each passing test
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>

    public int Add(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            return 0;
        }
        string[] numArray = digits.Split(new char[] { ',', '\n' });
        //string[] numArray = digits.Split(',');

        if (!numArray.Any() ||
            numArray.Count() > 2
            )
        {
            return -1;
        }

        int number;
        int sum = 0;
        foreach (string num in numArray)
        {
            if(!int.TryParse(num, out number))
            {
                return -1;
            }
            sum += int.Parse(num);
        }
        return sum;
    }
}