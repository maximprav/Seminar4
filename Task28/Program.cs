// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetPrd(num)}");

int GetPrd(int number)
{
    int prd = 1;
    while(number>1)
    {
        prd = prd*number;
        number--;
    }
    return prd;
}