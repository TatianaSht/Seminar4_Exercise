// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int NumberDegree (int numA, int numB)
{
    int result = 1;
    for(int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int numberA = ReadInt("Введите первое число: ");
int numberB = ReadInt("Введите второе число: ");

int degree = NumberDegree(numberA, numberB);
Console.WriteLine($"{numberA} в натуральной степени {numberB} = {degree}");
