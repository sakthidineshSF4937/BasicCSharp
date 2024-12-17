using System;
using System.Runtime.CompilerServices;
using Outside;

namespace Inside;

public class Program{
    public static void Main(string[] args)
    {  

        Son son=new Son();
        System.Console.WriteLine(son.PublicNumber);
        
        System.Console.WriteLine(son.privateNumber);

        parent parent=new parent();
        System.Console.WriteLine(parent.prot)

        System.Console.WriteLine(parent.InternalNumber);
        
        Grandparent grandparent=new Grandparent();
        System.Console.WriteLine(grandparent.);
    }
}
