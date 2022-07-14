//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Promt(string message)
{
 System.Console.Write(message);
 return int.Parse(Console.ReadLine());
}

double [,] GenerateArray(int row,int column, int min, int max)
{
    var array = new double [row, column];
    var rnd = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array [i, j] = rnd.NextDouble()*100;
        }
       }
       return array;
}

void PrintArray(double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write($"{array [i, j]:F2}" + "\t");
        }
        System.Console.WriteLine();
       }
}

int row = Promt("Количество строк: ");
int column = Promt("Количество столбцов: ");
int min = -10;
int max = 10;
double [,] array = GenerateArray(row, column, min, max);
PrintArray(array);