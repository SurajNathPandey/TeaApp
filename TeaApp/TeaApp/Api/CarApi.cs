using System;
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
        
