
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2



/*
int[,] Create2dArray (int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i< rows; i++)
    {
        for (int j = 0; j < columns; j ++)
        {
            newArray[i,j] = new Random(). Next (min, max +1);
        }
    }
return newArray;
}

void ShowArray (int [,] array1)
{
   
    for(int i = 0; i< array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j ++)
        {
            Console.WriteLine(array1[i,j]+ " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}

int[,] ChangeArrayRows(int[,] array1) 
{
     Console.Write ("Input number of rows : ");
     int user_rows = Convert.ToInt32(Console.ReadLine ());
     Console.Write ("Input number of columns: ");
     int user_columns = Convert.ToInt32(Console.ReadLine ());
     Console.Write ("Input number of min element : ");
     int user_minValue = Convert.ToInt32(Console.ReadLine ());
     Console.Write ("Input number of max element: ");
     int user_maxValue = Convert.ToInt32(Console.ReadLine ());

    if (user_minValue >= 0 && user_maxValue < array1.GetLength(0) && user_maxValue >= 0 && user_minValue < array1.GetLength(0))
     {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = array1[user_minValue,j];
            array1[user_minValue,j] = array1[user_maxValue,j];
            array1[user_maxValue,j] = temp;
        }
    return array1;
     }
     else 
    {

         ChangeArrayRows(array1);
         return array1;
    }
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next();
    }
  }
}

Console.Write ("Input number of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input number of column: ");
int user_columns = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input min number of value: ");
int user_minValue = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Input max number of value: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine ());


int[,] createdArray = Create2dArray (user_rows, user_columns, user_minValue, user_maxValue);
ShowArray(createdArray);
ShowArray(ChangeArrayRows(createdArray));
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] Create2dArray (int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i< rows; i++)
    {
        for (int j = 0; j < columns; j ++)
        {
            newArray[i,j] = new Random(). Next (min, max +1);
        }
    }
return newArray;
}

void ShowArray (int [,] array1)
{
   
    for(int i = 0; i< array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j ++)
        {
            Console.WriteLine(array1[i,j]+ " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}



int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/