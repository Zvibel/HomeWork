/*Задача 36: Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов, стоящих 
 на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-99, 100);
  }
  return arr;
}

int FindSum(int[] arr)
{
  var sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 != 0)
      sum = sum + arr[i];
  }
  return sum;
}

Console.WriteLine();

int[] array = InitArray(5);
int sum = FindSum(array);

Console.WriteLine("[{0}]", string.Join(", ", array));

Console.WriteLine($"-> сумма элементов, стоящих на нечётных позициях = {sum}.");