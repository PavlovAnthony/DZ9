/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

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
int RecursionFun(int n, int m)
{
    {
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return RecursionFun(n - 1, 1);
    else
      return RecursionFun(n - 1, RecursionFun(n, m - 1));
}
}
Console.WriteLine($"------Значение функции Аккермана с аргументами n и m---------");
int n = Convert.ToInt32(ReadData("Введите целое число n : "));
int m = Convert.ToInt32(ReadData("Введите целое число m : "));

Console.WriteLine("Значение функции  " + RecursionFun(n, m));




