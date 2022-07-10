// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] array = new int[8];
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);

// Честно признаюсь, решение ниже нашёл в сети
// Улавливаю суть работы этого кода, но нет полного понимания картины

// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 111);
//     Console.Write(" " + Method (i) + " ");
//  }
// Console.Write("]");

// int Method (int a)
// {
//     return numbers[a];
// }
