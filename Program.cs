// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}  ");
    Console.WriteLine();
}

string[] MassRead(int row)
{
    string[] arr = new string[row];

    for (int i = 0; i < row; i++)
        arr[i] = Console.ReadLine()!;
    return arr;
}

int MassSize(string[] arr)
{
    int MassLenght = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) MassLenght++;
    return MassLenght;
}

string[] MassNew(int row, string[] arr)
{
    string[] ArrNew = new string[row];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
        {
            ArrNew[j] = arr[i];
            j++;
        }
    return ArrNew;
}

Console.WriteLine("Введите размер массива: ");
int num_size = int.Parse(Console.ReadLine()!);

if (num_size > 0)
    Console.WriteLine($"Введите {num_size} Строк:");
string[] mass = MassRead(num_size);
Print(mass);

int new_mass_size = MassSize(mass);
if (new_mass_size == 0)
    Console.Write("Для нового массива, нету строк <= 3   ");
else
{
    string[] newmass = MassNew(new_mass_size, mass);
    Print(newmass);
}