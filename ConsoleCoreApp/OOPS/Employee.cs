using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class Employee
    {
        int _EmpCode;
        string _EmpName;
        float _EmpSalary;

        public Employee()
        {
            Console.WriteLine("Default constr called");
            this._EmpSalary = 20000;
        }
        public Employee(int _EmpCode, string _EmpName, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric constr-1 called");
           
        }
        public Employee(int _EmpCode,  float _EmpSalary)
        {
            this._EmpCode = _EmpCode;           
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric constr-2 called");

        }
        static Employee() //static constr
        {
            Console.WriteLine("Static constr called");
        }
        ~Employee() //Destructor
        {
            Console.WriteLine("Object Removed");
        }
        public void SetEmployeeDetails(int _EmpCode,string _EmpName,float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Details saved!!!!");
        }
        internal void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Detail is:");
            Console.WriteLine($"Code:{_EmpCode}\tName:{_EmpName}\tSalary{_EmpSalary}");
        }
    }
}
