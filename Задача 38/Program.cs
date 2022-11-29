//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Write("Введите желаемую длину массива: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arrLenght];
Console.WriteLine("Хотите заполнить массив вручную? (Введите Да или Нет):");
string strAnswer = Console.ReadLine();
if ((strAnswer == "Да") || (strAnswer == "да"))
{
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i}-й элемент:");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}
else if ((strAnswer == "Нет") || (strAnswer == "нет"))
{
    FillArray(array);
}
else
{
    Console.WriteLine("Я вас не понял! Я ухожу!");
    return;
}

Console.WriteLine("В массиве:");
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"максимальное число: {MaxItem(array)}, минимальное число: {MinItem(array)}, разница между ними: {MaxItem(array) - MinItem(array)}.");

void FillArray(double[] arr) //Метод заполняет массив рандомными числами
{
    var random = new Random();

    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble();
    }
}

double MaxItem(double[] arr) //Метод находит и возвращает максимальное число в массиве
{
    double max = 0;
    foreach (double item in arr) 
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}

double MinItem(double[] arr)//Метод находит и возвращает минимальное число в массиве
{
    double min = arr[0];
    foreach (double item in arr)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

void PrintArray(double[] arr)//Метод выводит массив на экран в формате [.., .., .., ..]
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}
