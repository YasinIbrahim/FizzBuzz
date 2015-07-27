using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FizzBuzz
{
    public FizzBuzz() { }

    public string checkFizzBuzz(int a)
    {
        if ((a % 3 == 0) && (a % 5 == 0))
        {
            return "FizzBuzz";
        }
        else if (a % 3 == 0)
        {
            return "Fizz";
        }
        else if (a % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return a.ToString();
        }
            
    }

}
