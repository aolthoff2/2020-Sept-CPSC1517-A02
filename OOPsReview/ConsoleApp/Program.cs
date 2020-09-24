using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the Window Class using the default constructor.
            //The system calls your class constructor, your code NEVER calls the constructor directly.
            //The "new" will use the indicated constructor.
            //The "new" actually makes the call to the constructor and returns the instance of the class.

            //Call to the Default constructor.
            Window myInstance = new Window(); //the system calls you class constructor

            //Results of the constructor
            Console.WriteLine($"Width {myInstance.Width}; Height {myInstance.Height}; Panes {myInstance.NumberOfPanes}; Manufacturer {myInstance.Manufacturer}");

            myInstance.Width = 1.2m;
            myInstance.Height = 1.2m;
            myInstance.NumberOfPanes = 3;
            myInstance.Manufacturer = "All-Weather Windows";

            Window myGreedyInstance = new Window(1.2m, 1.2m, 3, "All-Weather Windows");
        }
    }
}
