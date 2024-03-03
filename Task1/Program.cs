// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 


void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число N: "); 
    if(M > N)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    PrintNumbers(M, N);

}

void PrintNumbers(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber)
    {
        System.Console.Write(lastNumber);
        return;
    }
    System.Console.Write(firstNumber + ", ");
    PrintNumbers(firstNumber + 1, lastNumber);
}



int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}


Main();