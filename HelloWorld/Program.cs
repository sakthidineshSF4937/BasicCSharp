//library section

//namespace section
namespace HelloWorld;//file scoped named function
//class section
using System;

class Program
{
    public static void Main(string[] args)
    {
       int n=int.Parse(Console.ReadLine());
       for(int i=1;i<=n;i++){
        for(int s=1;s<=n-i;s++){
            Console.Write(" ");
        }
        for(int j=1;j <= i*2-i;j++){
            Console.Write("* ");
        }
        Console.WriteLine();
       }

    }
}



import java.util.Scanner;

public class Program {
    
    
    public static boolean isPrime(int num) {
        if (num <= 1) {
            return false;
        }
        for (int i = 2; i * i <= num; i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }
public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
       
      
        String S = scanner.nextLine();

        StringBuilder result = new StringBuilder();


  for (int i = 0; i < S.length(); i++) {
            if (Character.isDigit(S.charAt(i))) {
                int j = i;
                while (j < S.length() && Character.isDigit(S.charAt(j))) {
                    j++;
                }
                int count = Integer.parseInt(S.substring(i, j));               
                if (count % 2 == 0) {
                    char prevChar = S.charAt(i - 1);
                    result.append(String.valueOf(prevChar).repeat(count));
                } else {
                             result.append(S.substring(i - 1, j));
                }
                i = j - 1; 
            }
        }
        System.out.println("Output: " + result.toString());

}
