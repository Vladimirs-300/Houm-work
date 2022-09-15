// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Number = Prompt(" Введите число > ");
int i = 2;
System.Console.WriteLine(" Чётные числа от 1 до " + Number);
while (i <= Number)
{
    if (i % 2 != 1)
    {
        System.Console.Write(i + " ");
    }
    i += 2;
}