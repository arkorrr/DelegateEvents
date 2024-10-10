using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task6
{
    Func<int, bool> isOdd = x => x % 2 != 0;

    public void Task()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach(int i in array)
        {
            if(isOdd(i))
            {
                Console.WriteLine($"Число непарное {i}");
            }
        }
    }


}