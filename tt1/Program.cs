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

void SORT (int[,] mas)
{   int box = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {  
        {
           for(int k = 0; k < mas.GetLength(1)-1; k++)
            {
                for(int j = 0; j < mas.GetLength(1)-1; j++)
               {
                     if(mas[i, j] < mas[i, j+1])
                       {
                        box = mas[i, j];
                        mas[i, j] = mas[i, j+1];
                        mas[i, j+1] = box;
                       }
               }
            }
        }
    }  

}


Console.Clear();
Console.Write("Введите размерность массива: ");
int[] s = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,]mas = new int[s[0], s[1]];
DVUMAS(mas);
POKADVUMAS(mas);
SORT(mas);
Console.WriteLine();
POKADVUMAS(mas);

