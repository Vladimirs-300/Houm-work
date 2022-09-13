// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int isNumber1 = Prompt("Введите число 1 > ");
int isNumber2 = Prompt("Введите число 2 > ");
int isNumber3 = Prompt("Введите число 3 > ");
int max = isNumber1;

if (isNumber2 > max)
{
    max = isNumber2;
}

if (isNumber3 > max)
{
    max = isNumber3;
}

Console.WriteLine(" Максимальное число -> " + max);