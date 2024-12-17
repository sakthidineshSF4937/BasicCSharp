using System;
//Calculate the sum of the square of the numbers present between the two number limit.
public class Program{
    public static void Main(string[] args)
    {
    Console.WriteLine("Enter the Starting range:");
     int starting=int.Parse(Console.ReadLine());
     Console.WriteLine("Enter the Ending range:");
     int ending=int.Parse(Console.ReadLine());
     int sum=0;
     for(int i=starting;i<=ending;i++){
        sum=sum+(i*i);
     }   
     Console.WriteLine($"sum of the square of the numbers present between the two number limit:{sum}");
    }
}
