/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8*/


/*
1. метод, который получает случайное число
2. метод, который получает максимальную цифру числа
*/

//метод, который получает случайное число

/*int GetRandomNumber(int leftBound, int rightBound)
{
    int result = 0;
    Random rnd = new Random();

    result = rnd.Next(leftBound, rightBound + 1);// [leftBoung, rightBound)
    return result;
}

//метод, который получает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;// 96 / 10 = 9,6
    int secondDigit = number % 10;

    if(firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");*/

/* Напишите программу, которая выводит 
случайное трехзначное число и 
удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

/*int GetRandomValue()
{
    return new Random().Next(100, 1000);
}

int DeleteSecondNumber(int number)
{
    return (number / 100) * 10 + (number % 10);
}

int number = GetRandomValue();
int result = DeleteSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");
*/


/*Напишите программу, которая будет 
принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа 
выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

/*int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if (secondNumber % firstNumber == 0)
{
    Console.WriteLine($"второе число кратно первому");
}
else
{
    Console.WriteLine(secondNumber % firstNumber);
}*/





/*Напишите программу, которая принимает 
на вход число и проверяет, кратно ли оно 
одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> */

/*int GetNumber()
{ Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();

if (firstNumber % 7 == 0 && firstNumber % 23 == 0)

{
    Console.WriteLine($"число кратно 7 и 23");
}
else
{
    Console.WriteLine($"число не кратно 7 и 23");
}*/



/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

/*int GetNumber()
{ 
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}*/



/*Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();

int GetNumber()
{ 
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SearchSecondNumber(int number)
{
    return number / 10 % 10;
}

int number = GetNumber();
int result = SearchSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");