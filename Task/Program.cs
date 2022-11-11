/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/


Console.WriteLine("Введите массив строк через пробел:");
string[] symbols = Console.ReadLine()!.Split(' ');

PrintArray(CreatArray(symbols, 3));

string[] CreatArray(string[] array1, int numberSymbols)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= numberSymbols)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}