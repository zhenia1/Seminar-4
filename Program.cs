using System;
using static System.Console;

Clear();

int[] ar = AskNumbers();
WriteLine($"{String.Join(",", ar)} -> [{String.Join(",", ar)}]");

int[] AskNumbers()
{
    int[] ar = new int[8];
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = AskNumber(i + 1);
    }
    return ar;
}

int AskNumber(int i)
{
    Write($"Введите число {i}: ");
    return int.Parse(ReadLine());
}