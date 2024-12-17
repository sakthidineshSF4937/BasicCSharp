using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class Program{

public static void Main(string[] args)
{
    bool IsContinue=true;
do{
 Console.WriteLine("Enter the first number");
 int num1=int.Parse(Console.ReadLine());
 Console.WriteLine("Enter the Second number");
 int num2=int.Parse(Console.ReadLine());
 Console.WriteLine("Enter the choice");
 Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
int choice=int.Parse(Console.ReadLine());
 switch(choice){
    case 1:{
        Console.WriteLine($"The Addition of two number : {Add(num1,num2)}");
        break;
    }
    case 2:{
        Console.WriteLine($"The Subtraction of two number : {Sub(num1,num2)}");
        break;
    }
    case 3:{
        Console.WriteLine($"The Multiplication of two number : {Mul(num1,num2)}");
        break;
    }
    case 4:{
        Console.WriteLine($"The Divison of two number : {Div(num1,num2)}");
        break;
    }
    default:{
        Console.WriteLine("Invalid Choice");
        break;
    }
 }
 Console.WriteLine("Do you want to Continue");
 string str=Console.ReadLine();
if(str=="YES" ||str=="yes"){
    IsContinue=true;
}
else if(str=="No" ||str=="no"){
    IsContinue=false;
}
 
}while(IsContinue);
}
public static int Add(int num1,int num2){
    return num1+num2;
}
public static int Sub(int num1,int num2){
    return num1-num2;
}
public static int Mul(int num1,int num2){
    return num1*num2;
}
public static double Div(double num1,int num2){
    return num1/num2;
}
}