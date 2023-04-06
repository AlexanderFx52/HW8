void DVUMAS (int[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            mas[i, j] = new Random().Next(1, 100);
    }
}
void POKADVUMAS (int[,] mas)
{
        for(int i = 0; i < mas.GetLength(0); i++)
    {
            for(int j = 0; j < mas.GetLength(1); j++)
            Console.Write($"{mas[i,j]} \t");
            Console.WriteLine();
    }   
}
int POSIK(int[,] mas)
{
    int min = 0;
    for (int i = 0; i < mas.GetLength(1); i++)
        min += mas[0, i];
    for (int i = 1; i < mas.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
           { Sum += mas[i, j];}
        if (min > Sum)
            min = Sum;
    }
    return min;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] s = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,]mas = new int[s[0], s[1]];
DVUMAS(mas);
POKADVUMAS(mas);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов: {POSIK(mas)}");