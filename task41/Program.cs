/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

void GetArray(int[] ga)
{
    for (int i = 0; i < ga.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        int temp = int.Parse(Console.ReadLine()!);
        ga[i] = temp;
    }
}
int PosNum(int[] pn)
{
    int count = 0;
    for (int i = 0; i < pn.Length; i++)
    {
        if (pn[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];
GetArray(array);
Console.WriteLine();
int res = PosNum(array);
Console.WriteLine($"Количество положительных чисел: {res}");