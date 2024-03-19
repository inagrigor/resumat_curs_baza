// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
//  меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
//  алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ConvertStringArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arrs = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrs[j] = array[i];
            j++;
        }
    }
    return arrs;
}


string[] array = { "Hello", "2", "world", ":-0" };
string[] arrs = ConvertStringArray(array);
Console.WriteLine($"masiv: [{string.Join("; ", arrs)}]");


Console.WriteLine("Hello, World!");
