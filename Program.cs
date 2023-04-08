// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Print(double[] arr)
{
    int row = arr.GetLength(0);

    for (int i = 0; i < row; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

double[] MassNums(int row)
{
    double[] arr = new double[row];

    for (int i = 0; i < row; i++)
            arr[i] = int.Parse(Console.ReadLine()!);

    return arr;
}

int num_row = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num_row);
Print(mass);
