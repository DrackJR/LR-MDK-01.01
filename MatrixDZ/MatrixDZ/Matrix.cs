

using System;

namespace MatrixDZ
{
    public class Matrix
    {
        private int[,] values_;
        private int rows_;
        private int columns_;


        // Метод создания матрицы
        public void CreateMatrix(int rows, int columns)
        {
            rows_ = rows;
            columns_ = columns;
            values_ = new int[rows_, columns_];
        }

        // Метод установки значения в ячейку матрицу
        public void SetValueInMatrix(int row, int column, int value)
        {
            values_[row, column] = value;
        }

        // Метод получения значения из ячейки матрицы
        public int GetValueMatrix(int row, int column)
        {
            int value = values_[row, column];
            return value;
        }

        // Метод получения строк матрицы
        public int GetRows()
        {
            return rows_;
        }

        // Метод получения столбцов матрицы
        public int GetColumns()
        {
            return columns_;
        }

        // Метод вычисления определителя квадратной матрицы
        public int CalcDeterminant()
        {
            if (rows_ != columns_)
            {
                Console.WriteLine("Матрица не квадратная");
                return 0;
            }
            if (rows_ == 1)
            {
                return values_[0, 0];
            }
            if (rows_ == 2)
            {
                return values_[0, 0] * values_[1, 1] - values_[0, 1] * values_[1, 0];
            }
            Console.WriteLine("Матрица не квадратная");
            return 0;
        }
    }
}
