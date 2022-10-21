/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    CheckNumber(a);
    return a;
}

int CheckNumber(string x)
{
    int num = 0;

    bool isNum = int.TryParse(x, out num);
    if (isNum == false || num < 1)
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }
        return num;
}
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}
int RecursionFun(int num)
{
    if (num >= 1)
    {
        Console.Write($" {num} ");
        num = num - 1;

        RecursionFun(num);
    }
    return num;
}


Console.WriteLine($"------Вывод чисел в промежутке от N до 1 ---------");
int num = Convert.ToInt32(ReadData("Введите целое число N>1 : "));
PrintData($"Числа в промежутке от {num} до 1: ", " ");
RecursionFun(num);



