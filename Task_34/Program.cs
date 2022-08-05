// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int PositiveNumbers()
{
    int posNum = new Random().Next(100, 1000);
    return posNum;
}

System.Console.WriteLine(PositiveNumbers());
