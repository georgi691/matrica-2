using System;

class MatrixOperations
{
    static void Main()
    {
        // deklarirane na matrica
        int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrixB = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        // Събиране
        int[,] sumMatrix = AddMatrices(matrixA, matrixB);

        Console.WriteLine("Събиране:");
        PrintMatrix(sumMatrix);

        // Изваждане
        int[,] subtractMatrix = SubtractMatrices(matrixA, matrixB);

        Console.WriteLine("Изваждане:");
        PrintMatrix(subtractMatrix);

        // Умножение
        int[,] multiplyMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("Умножение:");
        PrintMatrix(multiplyMatrix);

        // Деление (по елементи)
        int[,] divideMatrix = DivideMatrices(matrixA, matrixB);

        Console.WriteLine("Деление (по елементи):");
        PrintMatrix(divideMatrix);
    }

    // Събиране на матрици
    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    // Изваждане на матрици
    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

    // Умножение на матрици
    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    // Деление на матрици по елементи
    static int[,] DivideMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                
                if (matrixB[i, j] != 0)
                {
                    result[i, j] = matrixA[i, j] / matrixB[i, j];
                }
                else
                {
                    
                    result[i, j] = 0;
                }
            }
        }

        return result;
    }

    // Извеждане на матрица
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
