/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетво столбцов: ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[rows, colum];
ArrayNumbers(arr);
Console.WriteLine();
Console.WriteLine("Массив до изменения: ");
PrintArray(arr);

for(int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                int temp = 0;
                temp = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = temp;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(arr);

void ArrayNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Введите размер прямоугольного массива: ");
int massRows = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = new int[massRows, massRows];
ArrayNumbers1(arr1);
PrintArray1(arr1);
int min_sum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < arr1.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        sum = sum + arr1[i, j];        
    }
    if (sum < min_sum)
    {
        min_sum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (min_sum));

void ArrayNumbers1(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray1(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int size = InputInt("Размерноть матриц: ");
int[,] matricA = new int[size, size];
int[,] matricB = new int[size, size];
ArrayNumbers2(matricA);
ArrayNumbers2(matricB);
int[,] matricC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matricC[i, j] = matricC[i, j] + (matricA[i, k] * matricB[k, j]);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void ArrayNumbers2(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            arr2[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray2(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write(arr2[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Матрица - А");
PrintArray2(matricA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray2(matricB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray2(matricC);


/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int size_mass1 = InputInt("Введите размерность массива 1: ");
int size_mass2 = InputInt("Введите размерность массива 2: ");
int size_mass3 = InputInt("Введите размерность массива 3: ");

int count_num = 100;

if (size_mass1 * size_mass2 * size_mass3 > count_num)
{
    Console.Write("Массив достаточно большой: ");
    return;
}

int[,,] result_num = Create3DMassiv(size_mass1, size_mass2, size_mass3);

for (int i = 0; i < result_num.GetLength(0); i++)
{
    for (int j = 0; j < result_num.GetLength(1); j++)
    {
        for (int k = 0; k < result_num.GetLength(2); k++)
        {
            Console.WriteLine($"[{i}, {j}, {k}] - {result_num[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassiv(int size1, int size2, int size3)
{

int[,,] arr3 = new int[size1, size2, size3];
    int[] values = new int[count_num];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            for (int k = 0; k < arr3.GetLength(2); k++)
            {
                arr3[i, j, k] = values[valueIndex++];
            }
        }
    }
    return arr3;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("Введите размер массива: ");
int size4 = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size4, size4];

int num1 = 1;
int i = 0;
int j = 0;

while (num1 <= size4 * size4)
{
    nums[i, j] = num1;
    if (i <= j + 1 && i + j < size4 - 1)
        ++j;
    else if (i < j && i + j >= size4 - 1)
        ++i;
    else if (i >= j && i + j > size4 - 1)
        --j;
    else
        --i;
    ++num1;
}

PrintArray3(nums);

void PrintArray3(int[,] arr4)
{
    for (int i = 0; i < arr4.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr4.GetLength(1); j++)
        {
            Console.Write(arr4[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");

    }
}
