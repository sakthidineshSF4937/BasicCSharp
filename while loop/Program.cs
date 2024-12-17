using System;

public class Program{
/*    public static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
         int i=0;
        while(number>=0){
            
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
            number--;
        }
    } */

    public static void Main(string[] args)
    {
      int a;
        bool temp1=false;
        while(!temp1){
              Console.WriteLine("Enter a valid number:");
              temp1 = int.TryParse (Console.ReadLine(),out a); 
              if(temp1){
                Console.WriteLine("valid number : "+ a);
                break;
              }  
              Console.WriteLine("Try Again...Enter the Vaild Input......");         
        }
         
    }
}
