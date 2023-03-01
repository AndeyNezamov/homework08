int[,] GenerateArray2DInt (int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray2DInt (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i <  resultMatrix.GetLength(0); i++)
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
            for(int k = 0; k < matrix1.GetLength(1); k++)
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
    return resultMatrix;
}

Console.Write("Enter row count matrix 1: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column count matrix 1: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myMatrix1 = GenerateArray2DInt(rows, cols, min, max);

Console.Write("Enter row count matrix 2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column count matrix 2: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myMatrix2 = GenerateArray2DInt(rows2, cols2, min2, max2);

Console.WriteLine("Matrix 1:");
PrintArray2DInt(myMatrix1);
Console.WriteLine("Matrix 2:");
PrintArray2DInt(myMatrix2);
Console.WriteLine("Multiplication is:");

if(myMatrix1.GetLength(1) != myMatrix2.GetLength(0))
    Console.WriteLine("Matrixes cannot by multiplied!");
else
{
    int[,] multipliedMatrix = MatrixMultiply(myMatrix1, myMatrix2);
    PrintArray2DInt(multipliedMatrix);
}