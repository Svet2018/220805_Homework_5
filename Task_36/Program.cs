// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int PositiveNumbers()
{
    int posNum = new Random().Next(-1000, 1000);
    return posNum;
};

int[] GenerateArray(int arg1)
{
  int [] genArray = new int[arg1];
  int length = genArray.Length;
  int index = 0;
  int a = 0;
  while(index < length)
  {
    a = PositiveNumbers();
    genArray[index] = a;
    index++;
    a = 0;
  }
  return genArray;
};

int EvenNumbers(int [] argArray)
{
    int length = argArray.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 !=0)
        {
            sum = sum + argArray[i];
        }
        System.Console.Write(argArray[i] + ", ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Сумма элементов на нечетных позициях:");
    return sum;
}

int GetNum()
{
    System.Console.WriteLine("Введите длину массива:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}

System.Console.WriteLine(EvenNumbers(GenerateArray(GetNum())));