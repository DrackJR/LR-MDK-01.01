

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
    }
}
