using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task5
{
    public void Task()
    {
        int number = int.Parse(Console.ReadLine());
        Func<int, int> cube = x => x * x * x;
        Console.WriteLine(cube(number));
    }
}

