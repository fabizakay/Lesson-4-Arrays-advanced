using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_HW_Arrays_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Targil 2
            //int[] arr2a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int totTry = 0;
            //for (int i = 0; i < arr2a.Length; i++)
            //{
            //    int indx = Array.IndexOf(arr2a, i+1);
            //    int trys = 0;
            //    Console.WriteLine("Enter a number");
            //    int num = int.Parse(Console.ReadLine());
            //    while (num != indx)
            //    {
            //        if (trys<5)
            //        {
            //            Console.WriteLine("Enter a number");
            //            num = int.Parse(Console.ReadLine());
            //            Console.WriteLine("you didnt guess, try again");
            //            trys++;
            //            continue;

            //        }
            //        else
            //        {
            //            Console.WriteLine("GAME OVER");
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"yeeee, you guess the number after {trys} tryes");
            //    totTry++;
            //}
            //Console.WriteLine($"yeeee, you guess the number after {totTry} tryes");
            #endregion

            #region targil 3

            //int[,] arr3 = new int[5, 5];
            //Random rnd = new Random();

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        arr3[i,j] = rnd.Next(1,11);
            //    }
            //}

            //Console.WriteLine("enter a number from array");
            //int num3 = int.Parse(Console.ReadLine());
            //for (int z = 0; z < arr3.GetLength(0); z++)
            //{
            //    for (int x = 0; x < arr3.GetLength(1); x++)
            //    {
            //        if (arr3[z,x] == num3)
            //        {
            //            Console.WriteLine($"the number is in x {x}, z = {z}");
            //        }

            //    }
            //}


            #endregion

            #region Targil 4

            //int[,] arr4 = new int[11, 11];

            //for (int i = 1; i < arr4.GetLength(0); i++)
            //{
            //    for (int j = 1; j < arr4.GetLength(1); j++)
            //    {
            //        arr4[i, j] = i * j;
            //        Console.Write("\t" + arr4[i,j]);

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region targil 6

            //int[,,] arr6 = new int[3, 3, 3];
            //Random rnd = new Random();
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr6.GetLength(1); j++)
            //    {
            //        for (int z = 0; z < arr6.GetLength(2); z++)
            //        {
            //            arr6[i,j,z] = rnd.Next(1, 10) + 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr6.GetLength(1); j++)
            //    {
            //        for (int z = 0; z < arr6.GetLength(2); z++)
            //        {
            //            Console.Write("\t" + arr6[i,j,z]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region targil 7

            //string[,] arr7 = new string[3, 4]
            //{
            //    {"*","*","*","*" },
            //    {"*","*","*","*" },
            //    {"*","*","*","*" }
            //};

            //for (int i = 0; i < arr7.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr7.GetLength(1); j++)
            //    {
            //        Console.Write("\t" + arr7[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region targil 9

            Console.WriteLine("enter number of classes");
            int numOfClasses = int.Parse(Console.ReadLine());
            int[][] classARR = new int[numOfClasses][];
            Random rnd = new Random();
            int avg = 0,sum = 0;
            int sizeOfClass = 0;
            for (int i = 0; i < classARR.Length; i++)
            {
                Console.WriteLine("enter size of class");
                sizeOfClass = int.Parse(Console.ReadLine());
                classARR[i] = new int[sizeOfClass];
                for (int j = 0; j < classARR[i][j]; j++)
                {
                    classARR[i][j] = rnd.Next(0, 101);
                    Console.WriteLine(classARR[i][j] + " ");
                }
            }
            int maxindex = 0;
            for (int i = 0; i < classARR.Length; i++)
            {
                for (int j = 0; j < classARR[i].Length; j++)
                {
                    sum += classARR[i][j];
                }
                if (sum / classARR[i].Length>avg)
                {
                    avg = sum / classARR[i].Length;
                    maxindex = i;
                }
            }
            Console.WriteLine($"Higher avg {avg} Its of class : {maxindex}");

            #endregion

        }
    }
}
