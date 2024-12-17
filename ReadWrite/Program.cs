// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     { 
//         int row=int.Parse(Console.ReadLine());
//         int cols=int.Parse(Console.ReadLine());
//         int[,] matrix=new int[row,cols];
//         int[,] transpose=new int[cols,row];
//         for(int i=0;i<row;i++){
//             for(int j=0;j<cols;j++){
//                 matrix[i,j]=int.Parse(Console.ReadLine());
//             }
//         }
//         for(int i=0;i<cols;i++){
//             for(int j=0;j<row;j++){
//                 transpose[j,i]=matrix[i,j];
//             }
//         }
//         for(int i=0;i<cols;i++){
//             for(int j=0;j<row;j++){
//                 Console.Write(transpose[i,j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


using System;
public class Program
{
  public static void Main(string[] args)
  {
    int size1=int.Parse(Console.ReadLine());
    int size=int.Parse(Console.ReadLine());
    int[,] matrix1=new int[size,size1];
    int[,] resmatrix=new int[size1,size];
    for(int i=0;i<size;i++){
        for(int j=0;j<size1;j++){
            matrix1[i,j]=int.Parse(Console.ReadLine());
        }
    }
    for(int i=0;i<size;i++){
        for(int j=0;j<size1;j++){
            resmatrix[j,i]=matrix1[i,j];
        }
    }
  for(int i=0;i<size1;i++){
    for(int j=0;j<size;j++){
        Console.Write(resmatrix[i,j]+" ");
    }
    Console.WriteLine();
  }
  }
}


