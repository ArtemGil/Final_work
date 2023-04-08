// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Print(string[] arr)
{
    int row = arr.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        Console.Write($"{arr[i]}  ");
        Console.Write($"-{arr[i].Length}-  ");
    }
    Console.WriteLine();
}

string[] MassRead(int row)
{
    string[] arr = new string[row];

    for (int i = 0; i < row; i++)
            arr[i] = Console.ReadLine()!;

    return arr;
}

int num_size = int.Parse(Console.ReadLine()!);

string[] mass = MassRead(num_size);
Print(mass);
