using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(4, 4)
            {
                [0, 0] = 10,
                [0, 1] = 20,
                [0, 2] = 30,
                [0, 3] = 40,

                [1, 0] = 11,
                [1, 1] = 21,
                [1, 2] = 31,
                [1, 3] = 41,

                [2, 0] = 12,
                [2, 1] = 22,
                [2, 2] = 32,
                [2, 3] = 42,

                [3, 0] = 13,
                [3, 1] = 23,
                [3, 2] = 33,
                [3, 3] = 43,
            };
            Matrix<int> matrix2 = new Matrix<int>(4, 4)
            {
                [0, 0] = 0,
                [0, 1] = 2,
                [0, 2] = 3,
                [0, 3] = 4,

                [1, 0] = 5,
                [1, 1] = 6,
                [1, 2] = 7,
                [1, 3] = 8,

                [2, 0] = 10,
                [2, 1] = 11,
                [2, 2] = 12,
                [2, 3] = 13,

                [3, 0] = 14,
                [3, 1] = 15,
                [3, 2] = 16,
                [3, 3] = 17,
            };

            /* for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     Console.Write(matrix1[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     Console.Write(matrix2[i, j] + " ");
                 }
                 Console.WriteLine();
             }*/

            //Operator +
            Matrix<int> SumMatrix = matrix1 + matrix2;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(SumMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            //Operator -
            Matrix<int> DecMatrix = matrix1 - matrix2;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(DecMatrix[i, j] + " ");
                }
                Console.WriteLine();

            }

            //Operator *
            Matrix<int> MultMatrix = matrix1 * matrix2;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(MultMatrix[i, j] + " ");
                }
                Console.WriteLine();

            }
            var hasZero = matrix1 ? false : true;
            Console.WriteLine("First Matrix has zeroes: {0}", hasZero);


            //Problem 4. Strings problem
            //Example 1
            var test = new Reversed();
            String str = "ab-cd";
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input : " + str);
            test.reversed(charArray);
            String revStr = new String(charArray);

            Console.WriteLine("Output : " + revStr);

            //Example 2 
           
            String str1 = "a-bC-dEf-ghIj";
            char[] charArray1 = str1.ToCharArray();

            Console.WriteLine("Input : " + str1);
            test.reversed(charArray1);
            String revStr1 = new String(charArray1);

            Console.WriteLine("Output : " + revStr1);

            Console.ReadLine();



            }
        }
    
}
