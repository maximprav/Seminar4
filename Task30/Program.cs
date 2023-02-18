// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];
int index = 0;
int size = array.Length;

PrintArray(array);

void PrintArray(int[] arr)
{
    while(index<size)
    {
        arr[index] = new Random().Next(0,2);
        Console.Write(arr[index] + " ");
        index++;
    }
}


