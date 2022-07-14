// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string FindingElement(int [,] array, int rowPosition, int columnPosition)
{
string result = "";
if (rowPosition > array.GetLength(0) || columnPosition > array.GetLength(1))
    {
        result = $"Такой позиции нет";
    }   
    else
       for (int i=0; i<array.GetLength(0); i++)
        {
         for (int j=0; j<array.GetLength(1); j++)
            {
              if (array[i,j]==array [rowPosition-1, columnPosition-1])
               {
                result = $"Элемент на введенной позиции: {array[i,j]}  ";
               }
            }
       } 
        return result;
}

int row = Promt("Количество строк: ");
int column = Promt("Количество столбцов: ");
int min = -10;
int max = 10;
int [,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();


int rowPosition = Promt("введите номер: ");
int columnPosition = Promt("введите номер: ");
System.Console.WriteLine(FindingElement(array, rowPosition, columnPosition));