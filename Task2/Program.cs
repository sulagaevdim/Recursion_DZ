// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int N = ReadInt("Введите число n: ");
    int M = ReadInt("Введите число m: ");
    System.Console.WriteLine(CalculationAkkerman(N, M));

}

int CalculationAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n > 0 && m == 0) return CalculationAkkerman(n - 1, 1);
    else return (CalculationAkkerman(n - 1, CalculationAkkerman(n, m - 1)));
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
}


Main();