using System;

public class Program{

    public static void Main(string[] args)
    {
        //Enter First value
        Console.Write("Enter First value: ");
        int a=int.Parse(Console.ReadLine());
        //Enter Second Value
         Console.Write("Enter Second value : ");
        int b=int.Parse(Console.ReadLine());
        //Choice
        Console.Write("Enter Choice :");
        char choice=char.Parse(Console.ReadLine());
        switch(choice){
            case '+':{
                Console.WriteLine(a+b);
                break;
            }
            case '-':{
                Console.WriteLine(a-b);
                break;
            }
            case '*':{
                Console.WriteLine(a*b);
                break;
            }
            case '/':{
                Console.WriteLine(a/b);
                break;
            }
            case '%':{
                Console.WriteLine(a%b);
                break;
            }
            default:{
                Console.WriteLine("Operation Invalid");
                break;
            }
        }
    }
}
