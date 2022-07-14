// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int Promt(string message)
{
 System.Console.Write(message);
 return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row,int column, int min, int max)
{
    var array = new int [row, column];
    var rnd = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(min, max+1);
        }
        
       }
       return array;
}

void PrintArray(int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write(array [i, j] + "\t");
        }
        System.Console.WriteLine();
       }
}

void PrintArray2(double[] array)
{
    foreach (double element in array) System.Console.Write($"{element:F1}; ");
    System.Console.WriteLine();
}
double [] AverageOfColumn(int [,] array)
{
    double [] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j<array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i<array.GetLength(0); i++) result += array[i,j];
        averageArray[j]=result/array.GetLength(0);
    }
       return averageArray;  
}

int row = Promt("Количество строк: ");
int column = Promt("Количество столбцов: ");
int min = -10;
int max = 10;
int [,] array = GenerateArray(row, column, min, max);
PrintArray(array);
double [] averageArray = AverageOfColumn(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray2(averageArray);
