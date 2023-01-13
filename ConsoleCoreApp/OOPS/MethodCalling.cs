using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class MethodCalling
    {
        //Method for call by value
        //                        30    50
        public void CallByValue(int x,int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");//50   80
        }
        //Method for call by reference behaviour using ref keyword
        public void CallByRef(ref int x, ref int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X:{x}\tY:{y}");//50   80
        }
        //Method for call by reference behaviour  using out keyword 
        public void CallByOutput(int x,int y,out int s,out int m,out int d)
        {
            s = x + y;
            m = x * y;
            d = x / y;           
        }

        //Method for call by Named/Optional arguments
        public void CallByNamedOptional(int id,string fname="Guest",
                                               string surname="",float salary=25000)
        {
            Console.WriteLine($"Welcome:{fname} {surname}");
            Console.WriteLine($"ID:{id}\t Salary:{salary}");
        }




    }
}
