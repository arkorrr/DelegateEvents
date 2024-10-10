using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

delegate int Operation(int number);

class Task4
{
    public Predicate<int> isEven = delegate (int number)
    {
        return number % 2 == 0;
    };
    public void Task()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(isEven(number));
    }
}