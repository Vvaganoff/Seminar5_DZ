//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Write("Введите желаемую длину массива: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLenght];
FillArray(array);
Console.Write("В массиве: ");
PrintArray(array);
Console.WriteLine($"-> {CountEven(array)} чётных чисел.");

void FillArray (int[] arr) //Метод заполняет массив рандомными числами от 100 до 999
{
    var random = new Random();
    
    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
}

int CountEven (int[] arr) //Метод считает количество чётных чисел в массиве
{
    int counter = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}



