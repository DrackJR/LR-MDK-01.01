using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix_2x2 = new Matrix();
            matrix_2x2.CreateMatrix(2, 2);
            matrix_2x2.SetValueInMatrix(0, 0, 1);
            matrix_2x2.SetValueInMatrix(0, 1, 2);
            matrix_2x2.SetValueInMatrix(1, 0, 3);
            matrix_2x2.SetValueInMatrix(1, 1, 4);
            matrix_2x2.Print();
            Console.WriteLine("Определитель квадратной матрицы = " + matrix_2x2.CalcDeterminant());

            Console.WriteLine();

            Matrix matrix_2x3 = new Matrix();
            matrix_2x3.CreateMatrix(2, 3);
            matrix_2x3.SetValueInMatrix(0, 0, 1);
            matrix_2x3.SetValueInMatrix(0, 1, 2);
            matrix_2x3.SetValueInMatrix(0, 2, 3);
            matrix_2x3.SetValueInMatrix(1, 0, 4);
            matrix_2x3.SetValueInMatrix(1, 1, 5);
            matrix_2x3.SetValueInMatrix(1, 2, 6);
            matrix_2x3.Print();
        }
    }
}
