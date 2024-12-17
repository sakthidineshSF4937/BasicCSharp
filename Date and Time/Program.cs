using System;
//Create a DateTime object with values (2021,8,10,10,40,32).

//1. Display the Year, Month, Day, Hours, Minutes, and Seconds of the above DateTime Object individually.


public class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"year: {date.Year} \nmonth: {date.Month}\ndate : {date.Day}\n hour: {date.Hour}\nminute: {date.Minute}\nsecond:{date.Second}\n");
       //2.. Convert the Datetime to string.
       string str=date.ToString("yyyy mm dd hh mm ss tt");
       Console.WriteLine(str);
       //2.. reverse the string.
        string[] str1=str.Split(" ");
    for(int i=str1.Length-1;i>=0;i--){
          Console.Write(str1[i]+" ");
    }  
    Console.WriteLine();            
//3. Get date time object in string format (yyyy/MM/dd hh:mm:ss tt) from user and print the year, month, and day.  
       
        Console.WriteLine("enter the date:");
        DateTime dt=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine($"year: {dt.Year}\nmonth: {dt.Month}\nday: {dt.Day}");

    }
}