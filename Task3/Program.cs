// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Number = Prompt(" Введите число > ");

if (Number % 2 == 1)
{
    System.Console.WriteLine(" Число " + Number + " четное ");
}
else
{
    System.Console.WriteLine(" Число " + Number + " не четное ");
}
