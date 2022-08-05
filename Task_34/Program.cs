// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int PositiveNumbers()
{
    int posNum = new Random().Next(100, 1000);
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

/*
void PrintArray(int[] arrayPrint)
{
  int lengthArray = arrayPrint.Length;
  int position = 0;
  while(position < lengthArray)
  {
    System.Console.Write(arrayPrint[position] + ", ");
    position++;
  }
}*/

int EvenNumbers(int [] argArray)
{
    int length = argArray.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (argArray[i] % 2 ==0)
        {
            sum = sum + 1;
        }
        System.Console.Write(argArray[i] + ", ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Четных чисел в массиве:");
    return sum;
}

int GetNum()
{
    System.Console.WriteLine("Введите длину массива:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}

System.Console.WriteLine(EvenNumbers(GenerateArray(GetNum())));





