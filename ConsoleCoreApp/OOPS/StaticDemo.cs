using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
   static internal class StaticDemo
    {
        //int id; //non-static data field
        static int count;//static data field
        //public StaticDemo()        {
        //    this.id = count++;
        //}
        //public void DisplayId()        {
        //    Console.WriteLine($"ID:{id}");
        //}
        public static void DisplayCount()        {
            Console.WriteLine($"Object created:{count}");
        }
        static StaticDemo()        {
            count = 0;
        }
    }
}
