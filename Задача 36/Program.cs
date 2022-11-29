//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0

Console.Write("Введите желаемую длину массива: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLenght];
FillArray(array);
int sum = SumOddPos(array);
Console.Write("В массиве: ");
PrintArray(array);
Console.Write($" -> сумма элементов с нечетным индексом равна: {sum}");

void FillArray(int[] arr) //Метод заполняет массив рандомными числами от 100 до 999
{
    var random = new Random();

    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 101);
    }
}

int SumOddPos(int[] arr) //Метод считает количество чётных чисел в массиве
{
    int sum = 0;
    for (int i = 1; i<arr.Length; i = i + 2)
    {
        sum = sum + arr[i] ;    
    }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}