Console.Clear();

double X1 = UserInput("Введите координату X1: ");

double Y1 = UserInput("Введите координату Y1: ");

double X2 = UserInput("Введите координату X2: ");

double Y2 = UserInput("Введите координату Y2: ");

double res = DisPoint (X1, Y1, X2, Y2);
Console.WriteLine($"{res}");

static double DisPoint (double X1, double Y1, double X2, double Y2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
}

static double UserInput (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? ""); 
}