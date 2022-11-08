// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3 символа. Превоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выпполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите элементы массива через запятую: ");

string arr = Console.ReadLine()!;
string[] array = arr.Split(',');
//Console.WriteLine(arr);

void ArrayElements(string[] array)
{
    string[] mas = new string[array.Length];
    Console.WriteLine("\nВывод элементов массива длина которых не более трех символов:");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            mas[i]=array[i];
            Console.Write(" "+mas[i]);
        }
    }
}
InitArray(array);