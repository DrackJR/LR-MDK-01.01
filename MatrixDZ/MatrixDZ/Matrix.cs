

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
    }
}
