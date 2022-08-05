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
  int a =0;
  while(index < length)
  {
    a = PositiveNumbers();
    genArray[index] = a;
    index++;
    a = 0;
  }
  return genArray;
};







