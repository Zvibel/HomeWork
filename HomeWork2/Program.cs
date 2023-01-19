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