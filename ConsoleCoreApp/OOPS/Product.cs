using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 public data field X
 constructor   X
 getter/setter/methods
 properties
 */

namespace ConsoleCoreApp.OOPS
{
    internal class Product
    {
        //pid   name  price brand mfg expd category btachno
        int _Pid;
        //public void SetId(int pid)
        //{
        //    this.pid= pid;
        //}
        //public int GetId()
        //{
        //    return pid;
        //}
        private Product()
        {

        }
        static Product() { }
        public int Pid
        {
            get { return _Pid; }
            set { value = _Pid; }
        }



    }
}
