using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int row;
            int column;
            Console.WriteLine("input row and column for the first Matrix");
            int.TryParse(Console.ReadLine(), out row);
            int.TryParse(Console.ReadLine(), out column);
            Matrix first = new Matrix(row, column);
            Console.WriteLine("input row and column for the second Matrix");
            int.TryParse(Console.ReadLine(), out row);
            int.TryParse(Console.ReadLine(), out column);
            Matrix second = new Matrix(row, column);
            first.PrintMatrix();
            first.PrintMatrix();
            Matrix sum = first + second;
            sum.PrintMatrix();
            Console.Read();

        }
    }
}
