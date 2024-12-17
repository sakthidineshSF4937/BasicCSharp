using System;
using System.Threading;

public class Program(){
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        string str2="";
        int Count=0;
        for(int i=0;i<str.Length;i++){
            for(int j=i+1;j<str.Length;j++){
                if(str[i]==str[j]){
                   str2=str.Remove(j);
                }
            }
            if(Count==0){
                 str2=str2+str[i];
            }
        }
        System.Console.WriteLine(str);
    }
}

//ravichandran