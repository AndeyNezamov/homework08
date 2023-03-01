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
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + "\t");
        Console.WriteLine();
    }
}

int RowSum(int[,] array, int rowIndex)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        result += array[rowIndex, i];
    return result;
}

Console.Write("Enter row count: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column count: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GenerateArray2DInt(rows, cols, min, max);
Console.WriteLine("Initial array:");
PrintArray2DInt(myArray);

int minSumRow = 0;
for(int i = 0; i < myArray.GetLength(0); i++)
    if(RowSum(myArray, minSumRow) > RowSum(myArray, i))
        minSumRow = i;
Console.WriteLine("Row with minimal sum of elements is: " + (minSumRow + 1));