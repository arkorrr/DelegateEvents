using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task3
{
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    public bool IsOdd(int number)
    {
        return number % 2 != 0;
    }


    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public bool IsFibonacci(int number)
    {
        if (number < 0) return false;

        int a = 0;
        int b = 1;

        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == number;
    }

    public void Task()
    {
        Predicate<int> checkEven = IsEven;
        Predicate<int> checkOdd = IsOdd;
        Predicate<int> checkPrime = IsPrime;
        Predicate<int> checkFibonacci = IsFibonacci;

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Парное: {checkEven.Invoke(number)}");
        Console.WriteLine($"Непарное: {checkOdd.Invoke(number)}");
        Console.WriteLine($"Простое число: {checkPrime.Invoke(number)}");
        Console.WriteLine($"Число фибоначи: {checkFibonacci.Invoke(number)}");
    }
}
