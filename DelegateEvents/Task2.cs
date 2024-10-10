using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double Op(double x, double y);

class Task2
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public void Task()
    {
        Op add = Add;
        Op subtract = Subtract;
        Op multiply = Multiply;

        Console.WriteLine(add.Invoke(1, 1));
        Console.WriteLine(subtract.Invoke(4, 3));
        Console.WriteLine(multiply.Invoke(3, 3));
    }

}