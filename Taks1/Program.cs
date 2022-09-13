// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int isNumberA = Prompt("Введите число > ");
int isNumberB = Prompt("Введите число > ");

if (isNumberA > isNumberB)
{
    Console.WriteLine("Первое число " + isNumberA + " больше чем второе " + isNumberB);
}
else
{
    Console.WriteLine("Второе число " + isNumberB + " больше чем первое " + isNumberA);
}

