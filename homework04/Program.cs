void PrintArray2DInt (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + " ");
        Console.WriteLine();
    }
}


int[,] GenerateSpiralArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int number = 1, minRow = 0, maxRow = rows - 1, minCol = 0, maxCol = cols - 1;
    while(number <= rows * cols)
    {
        for(int i = minCol; i <= maxCol; i++)
            array[minRow, i] = number++;
        minRow++;
        if(number > rows * cols) break;
        for(int i = minRow; i <= maxRow; i++)
            array[i, maxCol] = number++;
        maxCol--;
        if(number > rows * cols) break;
        for(int i = maxCol; i >= minCol; i--)
            array[maxRow, i] = number++;
        maxRow--;
        if(number > rows * cols) break;
        for(int i = maxRow; i >= minRow; i--)
            array[i, minCol] = number++;
        minCol++;
    }   
    return array;
}

Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GenerateSpiralArray(rows, cols);
PrintArray2DInt(myArray);