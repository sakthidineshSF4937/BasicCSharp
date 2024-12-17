using System;
using System.Reflection.PortableExecutable;
using Microsoft.Win32.SafeHandles;

public class Program{
    public static void Main(string[] args)
    {
        bool isrepeat=false;
        do{
            Console.WriteLine("Enter the number:");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0){
                 Console.WriteLine("The given number is Even");
            }
            else{
                 Console.WriteLine("The given number is Odd");
            }
             
            while(true){
            Console.WriteLine("Enter the choice");
             string choice=Console.ReadLine();
             if(string.Equals(choice, "yes", StringComparison.OrdinalIgnoreCase)){
                    isrepeat=true; 
                    break;
             }
             else if(string.Equals(choice, "NO", StringComparison.OrdinalIgnoreCase)){
                isrepeat=false;
                break;
             }
             else{
               
                Console.WriteLine("Invalid choice");
                
             }
             }
        }while(isrepeat);
        }
    }


