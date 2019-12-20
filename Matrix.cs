using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public class Matrix<T> : IEnumerable<T> 
    {
        private T[,] arr { get; set; }


        public Matrix(int rows, int cols)
        {

            this.arr = new T[rows, cols];
        }
        public T this[int rows, int cols]
        {
            get
            {
                ExceptionHandle(rows, cols);
                return arr[rows, cols];
            }
            set
            {
                ExceptionHandle(rows, cols);
                arr[rows, cols] = value;
            }
        }
        private void ExceptionHandle(int rows, int cols)
        {
            if (rows < 0 || rows >= arr.GetLength(0) || cols < 0 || cols >= arr.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {

            Matrix<T> Matrix = new Matrix<T>(matrix1.arr.GetLength(0), matrix1.arr.GetLength(1));

            for (int i = 0; i < matrix1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.arr.GetLength(1); j++)
                {
                    Matrix[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return Matrix;
        }
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            

            Matrix<T> Matrix = new Matrix<T>(matrix1.arr.GetLength(0), matrix1.arr.GetLength(1));

            for (int i = 0; i < matrix1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.arr.GetLength(1); j++)
                {
                    Matrix[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return Matrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> Matrix = new Matrix<T>(matrix1.arr.GetLength(0), matrix1.arr.GetLength(1));

            for (int k = 0; k < matrix1.arr.GetLength(0); k++)
            {
                for (int j = 0; j < matrix1.arr.GetLength(1); j++)
                {
                    for (int i = 0; i < matrix1.arr.GetLength(1); i++)
                    {
                        Matrix[k, j] = (dynamic)matrix1[k, i] * matrix2[i, j];
                    }
                }
            }
            return Matrix;
        }

        public static bool operator true(Matrix<T> matrix1)
        {
            bool result = false;
            for (int i = 0; i < matrix1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.arr.GetLength(1); j++)
                {
                    if ((dynamic)matrix1[i, j] != 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }
        public static bool operator false(Matrix<T> matrix1)
        {
            bool result = true;
            for (int i = 0; i < matrix1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.arr.GetLength(1); j++)
                {
                    if ((dynamic)matrix1[i, j] == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }



        
    }
}
