using System;

class Program
{
    static void Main()
    {
        int x = 15;
        int y = 15;

        if (x > y)
        {
            System.Console.WriteLine("x is greater than y!");
        }
        else if(x < y)
        {
            System.Console.WriteLine("x is less than y!");
        }
        else if(x == y)
        {
            System.Console.WriteLine("x is equel to y!");
        }
        else
        {
            System.Console.WriteLine("x and y are not comparable!");
        }

    }
}