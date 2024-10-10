using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MessageDelegate(string message);

class Task1
{
    public void Task()
    {
        MessageDelegate message = DisplayMessage;
        message("Hello World");
    }
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}