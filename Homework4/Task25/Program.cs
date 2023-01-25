/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNumber(string message)
{
    int resultNumber = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }

    return resultNumber;
}

int GetExponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

int numberA = GetNumber("Введите число A, которое не равна 0:");
int numberB = GetNumber("Введите число B:");
int exponentiation = GetExponentiation(numberA, numberB);

Console.WriteLine($"Число {numberA} в степени {numberB} равно {exponentiation}");


