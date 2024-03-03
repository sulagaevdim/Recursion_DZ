// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = [5, 3, 6, 1, 8, 9, 23, 156, 4];
    PrintFromTheEnd(array, array.Length - 1);

}

void PrintFromTheEnd(int[] array, int index)
{
    if(index == 0) {
        System.Console.Write(array[index]);
        return;
    } 
    System.Console.Write(array[index] + " ");
    PrintFromTheEnd(array, index - 1);
}

Main();