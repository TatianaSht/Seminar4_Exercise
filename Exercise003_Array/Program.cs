// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int [] arr, int minSize, int maxSize)
{
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
    arr[i] = rand.Next(minSize, maxSize);
    }
}

void PrintArray(int [] arr)
{
    Console.Write($"[{string.Join(", ", arr)}]");
}

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int lenArray = ReadInt("Введите размер массива: ");
int minSize = ReadInt("Введите минимальное значение для элемента массива: ");
int maxSize = ReadInt("Введите максимальное значение для элемента массива: ");
int [] array = new int [lenArray];
FillArray(array, minSize, maxSize);
PrintArray(array);
