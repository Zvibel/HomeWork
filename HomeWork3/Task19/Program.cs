/*Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

void CheckingNumber(string numberText)
{
    if (numberText[0] == numberText[4] || numberText[1] == numberText[3])
    {
        Console.WriteLine($"Ваше число: {numberText} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {numberText} - НЕ палиндром.");
}

if (numberText!.Length == 5)
{
    CheckingNumber(numberText);
}
else Console.WriteLine($"Введите пятизначное число");