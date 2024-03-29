﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TeaApp.Model;



namespace TeaApp.Api
{
    public class CarApi
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<CarModel>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/jly7p");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<CarModel>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}
// interview question and practice c#
1)what is typecasting.
    type casting is process to converting one data type value to other data type value.
    example convert string to int etc.
2) what is boxing and unboxing.
    it is procees of converting Valuetype datatype to reference type data type. 
    note- all data type except string is colled valuetype datatype. string is refrence type data type.
    
    so--> converting any data type to string is colled boxing. unboxing string to any data type.
    boxing example.
    int i = 10;
string s = i.Tostring();
   unboxing example
   string name ="suraj";
name=int.parse();
dataype.parse();
example. int.parse();, byte.parse(); ,double.parse();

3)conditional statment.
    A statment that will gate excute based on condition is called coditional statment.
    condition- A condition is use to compare 2 value or variable or expression.
    
    two type of condition
    1)if 
    2)switch 
    1)if-> a)if ,b)if else, c)else if ,d) multiple if e) nested if
       a) if)--> the statment will get excute when condition is true.
           if(true)
           {
               statment
           }
    example-
        if(2==2)
        {
            console.Writeline("i am suraj");
        }
   b)if else-->if condition is true . it will excute statment that was written inside if . If condition is falls. it will excute the statment which is written inside else. 
   
       example-
       if(2>1)
       {
           console.writenline("ok");
           
       }
       else
       { 
           console.writemline(" thanks");
       }
   
    c)else if-->it is use to check multiple condition and excute only one condition.
        if(condition)
        {
        }
        else if(condition)
        {
        }
        else if(condition)
        {
        }
        else if(condition)
        {
        }
example-->
    if(3>9)
    {
        console.WritenLine("ok");
            
    }
    else if(3==9)
    {
        C.W.L("thanks");
    }
    else if(3<9)
    {
        C.W.L("suraj");
    }
    else
    {
        C.W.L("nath");
    }
c)Multiple if-->it is use to check multiple condition and excute multiple condition.
    if(10>5)
    {
        C.W.L("hello");
    }
    if(20>2)
    {
        C.L.W("thanks");
    }
   if(10==10)
   {
       C.W.L(" thik hai");
   }
 e) Nested if--->the inner condition will get excute when outer condition is true.
     
     class suraj {
      static void Main(string[] args) {
         
         string a = "ram";
         srting b = "ravi";
         
         
         if (a == ram) {
            
            if (b == ravi) {
              
               Console.WriteLine("This is nested if");
            }
         }
         
 4)Switch case-->It will check perticular condition and excute all cases according to condition.
     switch(condition)
     {
             case1:
             break;
             case 2:
             break;
             case 3
             break;
         default:
             break;
     }
     q)write a program to expect a charecter from console and check whether given charecter is vowel or consonent.
using system;
class Program
{
 
    static void Main(string[] args)
    {
 
        char ch;
 
        //Reading an alphabet from user
        Console.WriteLine("Enter any alphabet: ");
        ch = Convert.ToChar(Console.ReadLine());
 
 
    // checking vowel and consonant
        switch (ch)
        {
            case 'a': Console.WriteLine("vowel");
                break;
            case 'e': Console.WriteLine("vowel");
                break;
            case 'i': Console.WriteLine("vowel");
                break;
            case 'o': Console.WriteLine("vowel");
                break;
            case 'u': Console.WriteLine("vowel");
                break;
            case 'A': Console.WriteLine("vowel");
                break;
            case 'E': Console.WriteLine("vowel");
                break;
            case 'I': Console.WriteLine("vowel");
                break;
            case 'O': Console.WriteLine("vowel");
                break;
            case 'U': Console.WriteLine("vowel");
                break;
            default: Console.WriteLine("consonant");
                break;
        }
 
        Console.ReadLine();
 
    }
 
}
          
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----  ---  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    loop--> Loop ia a mechanism which is use to excute repeatedly data again and again until the condition become false.
    Loop divided in two part -->a) (for loop) or range based loop b)(While loop) or conditional based loop.
    
    Every loop consist3 thing in common
    1)Initialization
    2)Condition
    3)Increment /Decrement
    
   1)Initialization--> it is use to initialize the initial value in a variable. ex- int i=5;
   2) Condition-->A condition will always return boolean value ither tue or false.
       or-> a condition is use to compare 2 value or variable.
       ex-10>2 -->true
       1>10 -->false
    3)increment / decrement operator
       ex- int i=5;
          i++; -->6
              i=i+1; --> 7
                  
                  i=i-1; -->5
   
   for(initialization;condition;increment/decrement)
   {
   }
  q)write a program to print suraj 5 times.
      
      using system;
          Class A
          {
              static void Main()
              {
                  for(int i=1; i<=5; i++)
                  console.WriteLine("Suraj");
              }
          }
        note->loop will reduce your code.
   q)Write a program to accept 6 number from console and find there sum.
      using system;
          class A
          {
              Static Void Main()
              {
                  int sum=0;
                  for(int i=1; i<=6; i++)
                  {
                      console.WriteLine("enter number");
                      int number=int.parse(console.ReadLine());
                      Sum=Sum+Number;
                      Console.WriteLine(sum);
                  }
              }
              
          }
      q)Write a program to print.
          *#*#*
          *#*#*
          *#*#*
          *#*#*
          *#*#*
         using system;
          class A
          {
              static void Main()
              {
                  for(int i=1;i<=5;i++)
                  {
                      for(int j=1; j<=5; j++)
                      {
                          if(j%2==0)
                          {
                              C.W.L("#");
                              
                          }
                          else
                          {
                              C.W.L("*");
                          }
                      }
                  }
              }
          }

    q)write a program to print.
        ----*
        ---**
        --***
        -****
        *****
        
        using System;
          Class A
          {
              Static void Main()
              {
                  for(int i=1; i<=5; i++)
                  {
                      for(int j=4;j>=1;j--)
                      {
                          Console.WriteLine("");
                    
                      }
                      for(int K=1;k=i;K++)
                      {
                          Console.WriteLine("*");
                      }
                      Console.WritenLine();
                  }
              }
          }
     
          While loop -->In while loop, the condition is checked before the body is executed
using System;
          1)initialization
          2)condition
          3)operator
					
public class Program
{
	public static void Main()
	{
		int i = 0;

		while (i < 5)
		{
		
			int m=i*2;
			Console.WriteLine("Value of i: {0}", m);
            i++
		
			
		}
	}
}
          
 output-->Value of i: 0
Value of i: 2
Value of i: 4
Value of i: 6
Value of i: 8
    
 q)write while loop for sum of first 5 natural numbers.
     using System;
namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
			int i=1, sum=0;
			while (i<=5)
			{
				sum += i;
				i++;
			}
			Console.WriteLine("Sum = {0}", sum);
		}
	}
}
  output--> 15
 
      do while loop --> in do while loop condition is checked after the body is executed.
   do
{
	// body of do while loop
}
while (condition);
 using System;
  
	class DoWhileLoop
	{
		public static void Main(string[] args)
		{
			int i = 1, n = 5, product;
			do
			{
				product = n * i;
				Console.WriteLine("{0} * {1} = {2}", n, i, product);
				i++;
			} while (i <= 10);
		}
	}
          
 q) Difference between While loop and Do while loop.
    ans-->The do and while keyword is used to create a do...while loop. It is similar to a while loop, however there is a major difference between them
  
  ---------------------------------------------------------------------------------------------------------------------------------------------------------
 -------------------------------------------------------------------------------------------------------------------------------------------------------------
 
      OOPS(object oriented principle system)
      -->object oriented principle system (oops) is a concept which is used to write computer program by using class and object.
      
      Principle of oops
      1)Abstraction
      2)Encapsulation
      3)Inheritance
      4)polymorphism
   
   q)what is object oriented programing language.
     ans-->Any language that support oops principle then that language is called object oriented programing language.
      example--> Java, C#.net etc.
  q)what is object based programing language.
    ans-->Any language that does not support atleast one principle of oops among the above 4. ++
          then that language is called as object based programing language.
  example-javascript.
      
  1)Abstraction -->It is a proceess of getting required data and hiding unnecessary data.
  
  2)Encapsulation-->It is proceess of binding or grouping of common set of state and behaviore(variable and method).
                    in a single container.
      note-->we can apply encapsulation by using class.
     
  3)Inheritance-->It is a mechanism of creating a new class by already existing class.
               OR-->It is mechanism of establisting relationship between two or more classes.
               OR--->Or Inheritance is mechanism to optaining variable and methods from one class to another class.
                   -->the class which is giving variable and method is called as Base class or super class or parent class.
                   -->the class which is taking variable and method is called as Drive class or sub class or child class.
                       : operator is called inheritance operator.
  
   q)What are the advantages of inheritance.
       1)Reusabitity
       2)Extensability
       3)Reimplementation
			       
    4)polymorphism --> polymorphism means one thing in many forrms. 
		       There are two type of polymorphism.
       1)Compile time Polymorphism 
       2)Run time polymorphism
			       
       1)Complile time polymorphism --> When output is dicided at Compile time is called compile time polmorphism.
          example--> overloading.
       2)Runtime polymorphism --> When Output is dicided at runtime is called runtime polymorphism.
	   example--> overriding.

Class-->Class is userDefind reference type datatype which consists of state(variable) and behavior(method).
 class Classname
{
	variable
        method
}
	      
ex
Class Employee
{
	int eno;
	string ename;
	double esalary;
	
   void setEmployeedata();
    {
	    //any logic
    }

void setEmployeedata();
    {
	    //any logic
    }
void setEmployeedata();
    {
	    //any logic
    }
}
	      
Object-->Object is instance of class.
Instace-->intance means allocating sufficient memory for instance variable.

whenever we creat an object for class then memory is allocated for instance variable.
	
Syntax for creating object
-->Classname objectname = new classname();

Q)what is diffence between class and object.
class
1)class can exist without object.
2)class does not have memory.
3)class consist of variable and method logicaly without memory.
Object
1)Object can not exist without class
2)object have memory.
3)object consists of instance variable and instance method with memory.

point to remember
1)class is an idea or plane to creat object.
2)We can creat multiple object for a single class.
3)class is loaded only one time but object is created multiple time.

Variable-->variable is a name given for a perticular memory location.
Q) What is the perpuse of variable
ans-->the perpuse of variable is identify a perticular memory location.
ex-- If we want to store the value in  memory. or if we want to retrive value from memory we use that variable name.
sntax- Datatype variablename;
	     int suraj =10;
	      
there are two type of variable.
1)static variable
2)instance variable

1)static varible must declare with static keword.
2)static varible must declare inside the class and outside the method with static keword.
Class
{
	//Static datatype variablename;
	static string complanyname;
    static void main()
	    
    {
    }
	
}
	   
	     
2)Instance -->Instance variable must declare inside class and outside the method without static keword.
Class Student
{
	int Sno;
	string Sname;
	
   static void main()
   {
   }
}
	      
Q)Difference between static variable and instace variable.
static
1)static variable diclare with static keyword.
2)The memory of static variable is allocated in stack.
3)the memory of statc variable will allocated at the time of class loading.
4)the memory for static variable will allocated only one time at the time of class loading.
5)static variable allocated common memory for all the object.
6)the lifespan of statice variable is ubtile the class is live.
7)sntax to acces static variable-- classname.variablename;
8)when data is common for all the object then make the variable as static.

Instance variable
1)no special keyword requered.
2)the memory for instance variable is allocated in heap.
3)the memory for instace variable is allocated when we creat object.
4)the memory for instace variable will allocated everyhing  time when we creat object
5)instance variable will allocate seperate memory for every object.
6)the lifespan of instance variable is untile the object live.
7)sntax to access instance variable is --- Objectname.variablename;
8)if data is unik for all object then make the variable as instance.

Q)Local variable-- the variable which declare withing the block or withing the method called local variable.
Rule
1)local variable must be declear within the block or within the method.
2)locat variable must not be static.
3)local variable must be initialize.
4)the scop of local variable is withing the method.

	class A
		
	{
		Static void main()
			
		{
			int x=10; //local variable
			if(10>2)
			{
				int y=20; //local variable
			}
		}
	}
	      
Method--->method is a subprogram which is use to perform some operation.
	
	method consists of two thing.
	method=method heading + method body.
1)method heading or method signature= assesmodifire(by defoult private) returntype + Methodname + parameter
2)Methodbody-->the code that we write within the block is called as method body.
{
}
	      
-->we must declear mrthod inside the class only.
	
ex- class classname
{
	void methodname() --->MA
	{
		
		---->MB
	}
}
	      
-->method will gets excuted when we call it.

there two type of method 
1)Static Method
2)Instance Method

Q)write a difference between static and instance method.
	
static method
1)static method must declear with static keyword.
2)static method use to perform operation on static variable.

Class Classname
{
	static void Methodname()
	{
	}
}
	      
3)sntax to call static method
 Classname.methodname();
 
Instance method
1)no more special keyword is required to use instace method.
2)Instance method is use to perform operation on instance variable.
	
Class Classname
{
	void Methodname()
	{
	}
}
3)sntax to call instance method
  objectname.methodname();

	     	      
Q)write a addition to two number program by using static method and static variable.
using System;
Class A
{
	static int x;
	static int y;
   static void Add()
   {
	   x=10;
	   y=20;
      console.writeline("sume is" + (x+y));
   }
   static void main()
   {
	   A.Add();
   }
}
Q)write addition of two program by using instance method and instance variable.

Using System;
Class A
{
	int x;
	int y;
  void Add()
  {
	  x=10;
	  y=20;
     conole.WriteLine("sum is" +(x+y));
  }

  static void main()
  {
	  A a1=new A();
	  a1.Add();
  }
}

note--> Method must have return type the return type must be void or any datatype.
    --> If return type is void method will not return any value.
    ---> if return type is data type method must be return value.
ex-
 class A
 {
	 public void methodname()
	 {
		 any logic.
	 }
 }

Class A
{
	public int methodname()
	{
		any logic
		
	    return 10;
	}
}
	    
-->can we call static method in another static method withing the same class
	without using classname.
Ans-->yes
ex-
using system;
Class A
{
	static void M1()
	{
	   Console.WriteLine("i am M1")
	}
	
	static void M2()
	{
		M1();
	   Console.WrileLine(" I am M2")
	}
	
	static void main()
	{
		M2();
	C.R.L("kfajfajfajfa");
	}
}
	      
Q)can we call instance method in another instance method within same class.
	without using Object.

Ans-->yes
ex-
using System;
Class A
{
	void M1()
	{
		Console.WriteLine(" i am M1")
	}
	
	Void M2()
	{
		M1();
	   Console.WriteLine(" i am M2");
	}
	
	Static void main()
	{
		console.WriteLine(" i am main");
	   
		A a1 = new A();
		a1.M2();
	  note-->object creation must requered for instance method.
	}
}
	      
-->can we call static method in instance method method directly without using class name.
	Ans--> yes

-->can we call instance method in static method directly without using object name.
	Ans--> no

common for both statment ex-

 Class A
{
	static void M1()
	{
		Console.WriteLine(" I am m1");
	}
	
	void M2()
	{
		M1();
	 Console.WriteLine("ssafafa")
	}
	
	Static void Main()
	{
		Console.WriteLine("adadadad");
		A a1 = new A();
		a1.M2();
	}
}

	
	      
	                  Passing parameter mechanism
                        ------------------------------
                        ------------------------------
Q)What is method parameters.

Asn-->the variable that are declear withing the method parathesis are called as method parameter.

Method parameters are two type

1)Formal parameters
2)Actual parameters

1)Formal parameters-- the variable that are declear at the time of declearing method are called 
   as formal parameter.

   Class A
    {
       void show (int x, int y) --->Formal Parameters
       {
       }
    }

2)Actual parameters--thwe variable which are declear at the time of calling the method are called
     as Actual parameters.

    Class A
    {
       void show () 
       {
         int a=4;
         int b=4;
        A a1 = new A();
        a1.show(a,b);--->Actual parameters
       }
    }

note--> In C#.net we can achieve passing parameter mechanism in two ways.

1) Call By Value.
2)Call By Refrence.

1) Call by value
Ans-->In this mechanism will pass the value at the time of calling the method.

     OR--In this mechanism the Modification in Formal parameter will not effect actual parameters.	
ex- 
	Using Sytem 
	Class A
        {
	   void show(int x, int y)
	   {
		   x=9;
	           y=8;
		   Console.WriteLine("X is"+X);
		   Console.WriteLine("Y is "+ y);
	   }
	Static void main()
	{
		A a1 =new A();
		int a=5;
		int b=6;
		a1.show(a,b);
		Console.writeline("a is" + a);
		Console.WriteLine("b is" +b);
	}
	   
        }
	      output-- 5,6
	      
2)Call by Reference -->It is mechanism of calling the method by passing the address.
  Or- In call by reference the modification in Formal parameter will effect Actual parameters.
	
Note-->We can achive call by refrence by using ref and out keyword.
	ex-
	Using System;
	Class A
	{
	   void show( ref int x, ref int y)---->(optional) or(out int x, out int y)--->(mandetory)
	   {
		   x=8;
		   y=9;
		   Console.WritenLine("X is " + x);
	           Console>WritenLine("y is " + y);
	   }
		Static void Main()
		{
			A a1 = new A();
			int a=5;
			int b=6;
			a1.show(ref a, ref b)(---->Mandetory); or (out a, out b);(--->optional)
			Console.WritenLine("a is " +a);
			Console.WriteLine("b is "+b);
		}
	}
	      
	      Output--8,9
		      
Q)Difference Between ref and out keyword.
		      
ref-
1)ref must declear with ref Keyword.
2)initialization of Formal parameter is optional.
3)initialization of Actual parameter is mandetory. 
		      
out--
1)out must declear with out keyword.
2)initialization of Formal parameters is mandetory.
3)initialization of Actual parameter is Optional.
		      
	  
		      Params Keyword
		      --------------
Q)Params Keyword-->it is using to pass parameter as a optional.

Param Keyword must declear in the last place of parameter list.
		      
note-->Params keyword can only Apply for Array not for variable.
	ex-
	Using System;
	Class A
	{
		Static void Show(int x, int y, params int []2)
		{
			Console.WritenLine(x);
			Console.WritenLine(y);
			Console.WritenLine(2.Length);
		}
		Static void Main()
		{
			A.show(5,6);
		}
	}
		    

 -----------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------
some important interview questions.
----	-----	------	    ---   ------ -----
Q)What is constroctor.
  ANS-->A constructor is a member function in a class that has the same name as its class. The constructor is automatically invoked whenever an object class is created.
	Constroctor is used to initializing class.  

Q)What is an object.
  ANS--> An object is an instance of a class.

Q) What is the difference between public, static, and void.
  ANS-->public-Public declared variables or methods are accessible anywhere in the application.
	static-Static declared variables or methods are globally accessible without creating an instance of the class. 
	void-Void is tells that the method or variable does not return any value.
	Note-Static member are by default not globally accessible it depends upon the type of access modified used.
		
Q)What is the use of 'using' statement in C#.
  ANS-->The 'using' block is used to obtain a resource and process it and then automatically dispose of when the execution of the block completed.
		
Q)Can multiple catch blocks be executed.
 ANS-->No, Multiple catch blocks can't be executed. Once the proper catch code executed, the control is transferred to the finally block, and then the code that follows the finally block gets executed.

Q)What is Jagged Arrays.
  ANS--> combination of single dimensional and multidiamentional array is called jagged array. OR Array of arrays is called jagged array.

Q)What is the difference between ref & out parameters.
 ANS-->An argument passed as ref must be initialized before passing to the method whereas out parameter needs not to be initialized before passing to a method.

Q)What is serialization.
 ANS-->When we want to transport an object through a network, then we have to convert the object into a stream of bytes. The process of converting an object into a stream of bytes is called Serialization. For an object to be serializable, it should implement ISerialize Interface. 
	 De-serialization is the reverse process of creating an object from a stream of bytes.

Q)Can we use "this" command within a static method.
  ANS-->We can't use 'This' in a static method because we can only use static variables/methods in a static method.

Q)What is the difference between constants and read-only.
  ANS-->Constant variables are declared and initialized at compile time. The value can't be changed afterward. Read-only is used only when we want to assign the value at run time.

Q)What is an interface class/
  ANS-->An Interface is an abstract class which has only public abstract methods, and the methods only have the declaration and not the definition. These abstract methods must be implemented in the inherited classes.
	 OR-> interface is used to achieve multiple inheritance which can't be achieved by class in .net.
	  -->interfaces will contain only the declaration of the members(means only method heding). The implementation of interface’s members will be given by class who implements the interface.

Q)What are value types and reference types.
 ANS-->A value type holds a data value within its own memory space.
       example--> Value type data type (int i=10; etc.)
       Reference type stores the address of the Object where the value is being stored. It is a pointer to another memory location.
	example--> string d="suraj";
	      
Q)What are Custom Control and User Control.
  Custom Controls are controls generated generated by default.
  those are easier to use and can be added to toolbox. Developers can drag and drop
  -->user Control are control generated by user. User controls can't be placed in the toolbox for drag and drop.

Q)What are sealed classes in C#.
 Ans-->We create sealed classes when we want to restrict the class to be inherited. if you want to stop inheritance for class make it seaed class.

Q)What is method overloading.
 ANS-->Method overloading is creating multiple methods with  same name but diffent paramiter. 
	note--> method will get excute when you call it. which method you call first that method will excute first. Ither when you created that method it's first method or not.
Q)What is method overriding.
  Ans--> If you want to modify one class method in other class use method overriding.
	 Or- If you want to overid parent (base class) method in child class(drive class) use method overriding.
       note- use virtual Keyword in parent class. and override keyword in child class.
	       
Q)What is the difference between Array and Arraylist.
   ANS-->Array is homozinios in neture. Arraylist hetrozinios in nature.
	  The size of the array is fixed. Array list doesn't have a fixed size.

Q)Can a private virtual method can be overridden.
  Ans-->No, because they are not accessible outside the class.
	  
Q)What are the differences between System.String and System.StringBuilder classes.
  ANS-->System.String is immutable. When we modify the value of a string variable, then a new memory is allocated to the new value and the previous memory allocation released.
	-->  System.StringBuilder is mutable where many operations can be performed without allocation separate memory location for the modified string.
		
 Immutable-->Immutable  is a type of object whose data cannot be changed after its creation. it's read only.
 
  Mutable-->
		
Q)How can we sort the elements of the Array in descending order.
  Ans-->Using Sort() methods followed by Reverse() method.

Q)Write down the C# syntax to catch an exception (part of exception handling) .
  Ans-->try block excute the code logic. when it will not excute error message will come in catch block.
	  try {
    method(); -- all logic
         } 
     catch (Exception ex) {
	   ex.erromessage.
          }

Q)What is difference between an interface and abstract class.
	
Ans-->Interface-->In Interface all method having puplic access modifire by default . Mean all methos will be public.
      Abstract -->In abastact method may have with different access modifire.
      Interface--> methods having only declaration(method heading) but no definition(method body).
      Abstract--> It is class which contain All class properties like variable method etc.
      Interface-->It will contain only public method decraration(method heading).

Q)What are generics in C#.NET.
Ans-->Generics are used to make reusable code. it will  increase type safety, and performance.
       Using generics, we can create collection classes. To create generic collection, System.Collections.Generic namespace should be used.
	      Generics promotes the usage of parameterized types.

Q)What is the difference between Finalize() and Dispose() methods.
Ans-->Dispose() is called when we want for an object to release any unmanaged resources with them. On the other hand,
	      Finalize() is used for the same purpose, but it doesn't assure the garbage collection of an object.
		      
Q)What are Custom Exceptions.
Ans-->Sometimes there are some errors that need to be handled as per user requirements. Custom exceptions are used for them and are used defined exceptions.

Q)What is the base class in .net from which all the classes are derived from.
Ans-->System.Object . System.Object is a base class in .net.
	
Q)What is delegates.
Ans-->A delegate is a type that will defines a method signature and it can pass a function as a parameter. 
      OR In simple words we can say delegate is a . NET object which points to a method that matches its specific signature.
      OR Delegates allow methods to be passed as parameters. Delegates can be used to define callback methods.
	   
Q)Types of delegates
 
Ans-->There are two types of delegates, singlecast delegates, and multiplecast delegates.
 
 a)Singlecast delegate
 
  Singlecast delegate point to single method at a time. In this the delegate is assigned to a single method at a time. They are derived from System.Delegate class.
 
 b)Multicast Delegate
 
  When a delegate is wrapped with more than one method that is known as a multicast delegate.
 
  In C#, delegates are multicast, which means that they can point to more than one function at a time. They are derived from System.MulticastDelegate class.

Q)What is the difference between a Struct and a Class.
  Ans-->Structs are value-type variables, and classes are reference types
	 Structs cannot be inherited. but class can be inherit.

Q)What are indexers in C# .NET.
  Ans-->Indexers are known as smart arrays in C#. It allows the instances of a class to be indexed in the same way as an array.

  Eg:

  public int this[int index]    // Indexer declaration
	  
Q) What is difference between the "throw" and "throw ex" in .NET?

Ans-->   "Throw" statement preserves original error stack whereas "throw ex" have the stack trace from their throw point. 
	  It is always advised to use "throw" because it provides more accurate error information.
	 
Q)What are C# attributes and its significance?

Ans-->C# provides developers a way to define declarative tags on certain entities, eg. Class, method, etc. are called attributes. 
	  The attribute's information can be retrieved at runtime using Reflection.
	 
Q)How to implement a singleton design pattern in C#?

In a singleton pattern, a class can only have one instance and provides an access point to it globally.

Eg:

Public sealed class Singleton
{
Private static readonly Singleton _instance = new Singleton();
}
	      
Q)Is C# code is managed or unmanaged code?
	
Ans-->C# is managed code because Common language runtime can compile C# code to Intermediate language.	 

Q)What do you understand by regular expressions in C#.
	
Ans--> Regular expression is a template for matching a set of input. It can consist of constructs, character literals, and operators. 
	Regex is used for string parsing, as well as replacing the character string.

Q)Explain Reflection in C#.
		
Ans-->The ability of code to access the metadata of the assembly during runtime is called Reflection. 

Q) Why do we use Async and Await in C#?
	
Ans--> Processes belonging to asynchronous programming run independently of the main or other processes. 
	In C#, using Async and Await keywords for creating asynchronous methods.
		
Q)Can “this” be used within a static method.
		
Ans-->We can't use this in a static method because the keyword 'this' returns a reference to the current instance of the class containing it. 
      Static methods (or any static member) do not belong to a particular instance.
		
Q)What are partial classes?
 
Ans-->A partial class is only use to splits the definition of a class in two or more classes in a same source code file.  You can create a class definition in multiple files but it will be compiled as one class at run time.
	when you will create an instance of this class so you can access all the methods from all source file with a same object.

Partial Classes can be create in the same namespace it’s doesn’t allowed to create a partial class in different namespace. So use “partial” keyword with all the class name which you want to bind together with the same name of class in same namespace, 
Ex-public partial class Employee
{
    public void DoWork()
    {
    }
}

public partial class Employee
{
    public void GoToLunch()
    {
    }
}
	      
Q)What is Linq(Language Integrated Query).
Ans-->LINQ (Language Integrated Query) is uniform query syntax in C# to retrieve data from different sources and formats.
      It will provid a single querying interface for different types of data sources.	
      LINQ is a structured query syntax built in C# and VB.NET to retrieve data from different types of data sources such as collections, ADO.Net DataSet, XML Docs, web service and MS SQL Server and other databases.
	     
example-->gets all name from an array which contains 'a'.
	     
 using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		// Data source
		string[] names = {"Bill", "Steve", "James", "Mohan" };
        
		// LINQ Query 
        var myLinqQuery =  from myname in names
            			   where myname.Contains('a')
            				select myname;
        
		// Query execution
        foreach (var name in myLinqQuery)
            Console.Write(name + " ");
	}
}

to check this code https://www.tutorialsteacher.com/codeeditor?cid=cs-qqYNum
	      
Q)what is abstract class
	
ANS--> Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
	OR
	An abstract class is a class that is declared abstract —it may or may not include abstract methods. Abstract classes cannot be instantiated, but they can be subclassed.
	OR 
	Abstract class Declear with abstract keyword all thing which there in a general class it may there in abstract class, apart from it abstract class may contain
	abstract method which is not there in general class. we can't creat object for abstract class , we have use in different class with help of inheritance .
Q)Why do we use abstract in C#.
	
Ans-->The purpose of an abstract class is to provide a blueprint for derived classes and set some rules what the derived classes must implement when they inherit an abstract class.
	OR
       You can take advantage of abstract classes to design components and specify some level of common functionality that must be implemented by derived classes.
	
Q)What is abstract Method.
Ans--->	An Abstract method is a method without a body. The implementation of an abstract method is done by a derived class. When the derived class inherits the abstract method from the abstract class, it must override the abstract method. 
	This requirment is enforced at compile time and is also called dynamic polymorphism.

	using System;

namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }
  Example 1
	  
  // Derived class (inherit from Animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}
	      
Example 2
	abstract class Language {

  // abstract method
  public abstract void display1();

  // non-abstract method
  public void display2() {
    Console.WriteLine("Non abstract method");
  }
}
	      
	      Inheriting Abstract class
              -------------------------
using System;
namespace AbstractClass {

  abstract class Language {

    // non-abstract method
    public void display() {
      Console.WriteLine("Non abstract method");
    }
  }

  // inheriting from abstract class
  class Program : Language {

    static void Main (string [] args) {
      
      // object of Program class
      Program obj = new Program();

      // access method of an abstract class
      obj.display();

      Console.ReadLine();
    }
  }
}


