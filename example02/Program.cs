//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] InitMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int number = GetNumber("Введите число, которое надо найти в массиве");
int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);

bool numberIsExist = false;
int ind1 = 0, ind2 = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
   {

    if(number == matrix[i, j])
    {
       numberIsExist = true;
       ind1 = i;
       ind2 = j;
        break;    
    }

   }
}

 if(numberIsExist)
{
      
    Console.WriteLine($"Индексы числа: [{ind1},{ind2}]");
}
else
{
    Console.WriteLine("Такого числа нет в массиве.");
}
    


