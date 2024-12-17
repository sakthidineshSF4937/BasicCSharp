using System;

namespace ConditionalStatement;

class Program{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the marks:")
        int mark=Convert.ToInt32(Console.ReadLine());

        if(mark>=80 && mark<=100 ){
            Console.WriteLine("Grade A");
        }
        else if(mark>=60 && mark<=80){
           Console.WriteLine("Grade B"); 
        }
          else if(mark>=36 && mark<=60){
           Console.WriteLine("Grade C"); 
        }
       else{
        if(mark<=36 && mark>=0){
         Console.WriteLine("Grade D");
        }
        else{
            Console.WriteLine("Input Invaild");
        }
       }
    }
}
