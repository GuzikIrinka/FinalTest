// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System; 
using static System.Console;

Clear();

Write("Введите элементы массива через пробел: ");
WriteLine();

string[] array3 = GetArrayFromString(ReadLine());
string[] array2 = new string[array3.Length];

Write($"[{String.Join(",", array3)}] - > ");

SecondArrayWithIF(array3, array2);

PrintArray(array2);

string[] GetArrayFromString(string arrStr)
{

    string[] ArS = arrStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[ArS.Length];
    for (int i = 0; i < ArS.Length; i++)
    {
        result[i] = ArS[i];
    }
    return result;
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
