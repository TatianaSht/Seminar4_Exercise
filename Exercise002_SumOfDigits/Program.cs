// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInt(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number%10;
        number = number / 10;
    }
    return sum;
}

int number = ReadInt("Введите число: ");
int sum = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");