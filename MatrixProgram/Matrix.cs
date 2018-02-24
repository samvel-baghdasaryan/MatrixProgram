using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProgram
{
    /// <summary>
    /// Matrix Class
    /// </summary>
    public class Matrix
    {
        public List<List<double>> M = new List<List<double>>();
        /// <summary>
        /// one row for our Matrix
        /// </summary>
        private List<double> rowl = new List<double>();
        /// <summary>
        /// Matrix row count
        /// </summary>
        public int row;
        /// <summary>
        /// Matrix column count
        /// </summary>
        public int column;
        /// <summary>
        /// Random number for Matrix initialization
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Matrix constructor
        /// </summary>
        /// <param name="row">rows</param>
        /// <param name="column">columns</param>
        public Matrix(int row, int column)
        {
            this.row = row;
            this.column = column;
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    rowl.Add(random.Next(1, 4));
                }
                M.Add(rowl);
                rowl = new List<double>();
            }
        }
        /// <summary>
        /// Transpose Matrix
        /// </summary>
        /// <returns>Transposed Matrix</returns>
        public Matrix Transpose()
        {
            Matrix Result = new Matrix(this.column, this.row);
            for (int i = 0; i < this.row; ++i)
            {
                for (int j = 0; j < this.column; ++j)
                {
                    Result.M[j][i] = this.M[i][j];
                }
            }
            return Result;
        }
        /// <summary>
        /// Matrix Print
        /// </summary>
        public void PrintMatrix()
        {
            for (int i = 0; i < this.row; ++i)
            {
                for (int j = 0; j < this.column; ++j)
                {
                    Console.Write(this.M[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Maximum and Minimum number search and print
        /// </summary>
        public void PrintMaxAndMin()
        {
            double min = this.M[0][0];
            double max = this.M[0][0];
            for (int i = 0; i < this.row; ++i)
            {
                for (int j = 0; j < this.column; ++j)
                {
                    if (this.M[i][j] < min)
                    {
                        min = this.M[i][j];
                    }
                    if (this.M[i][j] > max)
                    {
                        max = this.M[i][j];
                    }
                }
            }
            Console.WriteLine("Maximum is: " + max + " minimum is: " + min);
        }
        /// <summary>
        /// Add Function for Matrixesfe
        /// </summary>
        /// <param name="M1">First Matrix</param>
        /// <param name="M2">Second Matrix</param>
        /// <returns></returns>
        public static Matrix Add(Matrix M1, Matrix M2)
        {
            if (M1.row != M2.row || M1.column != M2.column)
            {
                throw new Exception();
            }
            else
            {
                Matrix M3 = new Matrix(M1.row, M1.column);
                for (int i = 0; i < M1.row; ++i)
                {
                    for (int j = 0; j < M1.column; ++j)
                    {
                        M3.M[i][j] = M1.M[i][j] + M2.M[i][j];
                    }
                }
                return M3;
            }
        }
        /// <summary>
        /// Multiplying two Matrixes
        /// </summary>
        /// <param name="M1">First Matrix</param>
        /// <param name="M2">Second Matrix</param>
        /// <returns></returns>
        public static Matrix Multiply(Matrix M1, Matrix M2)
        {
            double sum;
            Matrix M3 = new Matrix(M1.row, M2.column);
            for (int k = 0; k < M1.row; ++k)
            {
                for (int j = 0; j < M2.column; ++j)
                {
                    sum = 0;
                    for (int i = 0; i < M2.row; ++i)
                    {
                        sum += M1.M[k][i] * M2.M[i][j];
                    }
                    M3.M[k][j] = sum;
                }
            }
            return M3;
        }


        /// <summary>
        /// Adding Two Matrixes
        /// </summary>
        /// <param name="M1">First</param>
        /// <param name="M2">Second</param>
        /// <returns></returns>
        public static Matrix operator +(Matrix M1, Matrix M2)
        {
            Matrix result = new Matrix(M1.row, M1.column);
            result = Add(M1, M2);
            return result;
        }
        /// <summary>
        /// Multiplying by Integer overload for Matrix
        /// </summary>
        /// <param name="a"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static Matrix operator *(int a, Matrix M)
        {
            Matrix result = new Matrix(M.row, M.column);
            for (int i = 0; i < M.row; ++i)
            {
                for (int j = 0; j < M.column; ++j)
                {
                    result.M[i][j] = a * M.M[i][j];
                }
            }
            return result;

        }

    }
}
