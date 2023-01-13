using ConsoleCoreApp.Day4;
using ConsoleCoreApp.OOPS;

// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
int x = 20;
Console.WriteLine($"value of x:{x}");
ConsoleCoreApp.Day4.Test.Main();
Test.Main();
*/

/*
//ReadKey
Console.WriteLine("Press any Key:");
//ConsoleKeyInfo ck= Console.ReadKey();
ConsoleKeyInfo ck = Console.ReadKey(true);
Console.Write("*");
//ck.Key =>ConsoleKey
//ck.key=>char
Console.WriteLine($"\nPressed Key:{ck.Key}");
Console.WriteLine($"Pressed Key keychar:{ck.KeyChar}");
//abcd123Enter
*/
/*
string password = "";
Console.WriteLine("Enter your Password:");
*/
//logic goes here
/*
ConsoleKeyInfo ck = Console.ReadKey(true);//a
while (ck.Key != ConsoleKey.Enter)
{
    Console.Write("*");//**
    password += ck.KeyChar;//ab
    ck = Console.ReadKey(true);//bEnter
}*/

/*
do {
    ConsoleKeyInfo ck = Console.ReadKey(true);
    Console.Write("*");
    if (ck.Key != ConsoleKey.Enter)
        password += ck.KeyChar;
    else
        break;
} while(true);

Console.WriteLine($"\nPassword is : {password}");
*/

/*
//using foreach
int[] arr = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine("Array elements are:");
/*
//forward only 
//readonly 
foreach(type identifier in collection/array-name){
     //statements
}
*/
/*
foreach(int item in arr)
{
    //item = item + 20; //invalid
    Console.WriteLine(item);
}
*/
//Boxing & Unboxing
/*
int num = 30;
object obj = num;//boxing
Console.WriteLine(obj);
int y =(int)obj; //unboxing
Console.WriteLine(y);
*/
//float z =(float)obj;  //not valid
//Console.WriteLine(z);

//object,var,dynamic
/*
var v = num;
int a = v;
Console.WriteLine(v);
Console.WriteLine(a);

dynamic dvar = num;
int b = dvar;
Console.WriteLine(dvar);
Console.WriteLine(b);
*/
/*
int[] arr = new int[5] { 10, 20, 30, 40, 50 };
foreach ( dynamic item in arr)
{
    if (item == 20) { 
    }
}*/
/*
******************************************************
12,Jan 2023
******************************************************
*/

//Object Creation
/*
Employee employee = new Employee();
//Member calling
employee.DisplayEmployeeDetails();//0,null,0
employee.SetEmployeeDetails(1000, "Ratish", 245000.0f);
employee.DisplayEmployeeDetails();
Employee emp2 = employee;
emp2.DisplayEmployeeDetails();//1000
emp2.SetEmployeeDetails(1001, "Rohit", 25450.0f);

employee.DisplayEmployeeDetails();//1001
emp2.DisplayEmployeeDetails();//1001   

var emp3 = new Employee();
dynamic emp4 = new Employee();

Employee emp5 = new();

emp5.DisplayEmployeeDetails();

new Employee().DisplayEmployeeDetails();
*/

/*
//Method Calling
MethodCalling obj = new ();
int num1 = 150, num2=10,sum,multi,div;
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");//30,50
obj.CallByValue(num1, num2);  //50    80
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");//30   50
//obj.CallByRef(ref num1, ref num2);
//Console.WriteLine($"Num1:{num1}\tNum2:{num2}");//50   80
obj.CallByOutput(num1, num2,out sum, out multi, out div);
Console.WriteLine($"Sum:{sum}\tMultiplication:{multi}\tDivision:{div}");//160,1500,15


obj.CallByNamedOptional(101, "Rohit", "Kumar",35450);//
obj.CallByNamedOptional(fname:"Rohit",surname:"Kumar",id:101,salary:35450);//use of named argument
obj.CallByNamedOptional(fname: "Rohit", surname: "Kumar", id: 101);

obj.CallByNamedOptional(fname: "Ratish",id: 102);
obj.CallByNamedOptional(fname: "Ratish", id: 102,salary:40000);

obj.CallByNamedOptional(id:105);

*/

/*
**************************************************
  13th Jan,2023
**************************************************
*/
/*
Employee emp1 = new Employee();
Employee emp2 = new();

Employee emp3 = new(101,"Ratish",25000);
Employee emp4 = new(102, "Rohit", 24000);

Employee emp5= new(103,  35000);


emp1.DisplayEmployeeDetails();
emp2.DisplayEmployeeDetails();
emp3.DisplayEmployeeDetails();
emp4.DisplayEmployeeDetails();
emp5.DisplayEmployeeDetails();
emp5 = null;
GC.Collect(0);
*/
/*
//using Point Class
Point p1 = new Point(20, 30);
Point p2 = new Point(20, 30);

Point p3 = p1 + p2;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Point p4 = p1 - p2;
Console.WriteLine(p4);


if (p1 == p2)
{
    Console.WriteLine("Both are same");
}
else
    Console.WriteLine("Both are different");

*/

//using StaticDemo

//StaticDemo s1 = new StaticDemo();
//StaticDemo s2 = new StaticDemo();
//StaticDemo s3 = new StaticDemo();

//s3.DisplayId();//2
//s2.DisplayCount();  //invalid
StaticDemo.DisplayCount();//3
//s1.DisplayId();//0

//Product p = new Product();

SingletonPattern obj = SingletonPattern.GetObject();
obj.Display();



















































