using System;
using Microsoft.Win32.SafeHandles;

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the names:");
        string[] arr=new string[5];
        for(int i=0;i<arr.Length;i++){
            
            arr[i]=Console.ReadLine();
        }
        Console.WriteLine("-----------------------------------------------");
         for(int i=0;i<arr.Length;i++){
        
           Console.WriteLine(arr[i]);
        } 
     Console.WriteLine("Enter the name to search:");
     string name=Console.ReadLine();
      for(int i=0;i<arr.Length;i++){
            
            if(arr[i].Equals(name)){
                System.Console.WriteLine($"The name {name} is present in array in position {i}");
                break;
            }
            else{
                Console.WriteLine("The name is not present");
                break;
            }
        }
        foreach(string str in arr){
             int count=0;
             bool isvalid=true;
              
              if(str.Equals(name)){
                  System.Console.WriteLine($"The name {name} is present in array in position {count}");
                break;
              }
               else{
                Console.WriteLine("The name is not present");
                break;
            }
        count++;
        }

    }
}
