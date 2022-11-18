Console.Clear();

int N = 0;

InitQuarterByUser(ref N);
PrintCoord(N);

static void InitQuarterByUser(ref int N)
{
    Console.Write("Введите номер четверти от 1 до 4: ");
    int N = int.Parse(Console.ReadLine() ?? "");
}

static void PrintCoord(int N)
{
    if (N == 1)
        Console.WriteLine("Диапозон значений: Х > 0, Y > 0");

    else if (N == 2)
        Console.WriteLine("сдДиапозон значений: Х < 0, Y > 0");

    else if (N == 3)
        Console.WriteLine("Диапозон значений: Х < 0, Y < 0");

    else if (N == 4)
        Console.WriteLine("Диапозон значений: Х > 0, Y < 0");

    else
        Console.WriteLine("Ошибка ввода");
}