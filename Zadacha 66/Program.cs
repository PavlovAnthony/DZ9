/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
int RecursionFun(int m, int n, int sum)
{
    if (m < n)
    {
        sum = sum + m;
        m = m + 1;
        RecursionFun(m, n, sum);  
        sum=sum+m;      
        Console.WriteLine("Сумма элементов " + sum);
        Environment.Exit(0);
    }
          if (m > n)
    {

        sum = sum + n;
        n = n + 1;
        RecursionFun(m, n, sum);
        sum=sum+m;
        Console.WriteLine("Сумма элементов " + sum);
        Environment.Exit(0);

    }

    return sum;
}
Console.WriteLine($"------Сумма элементов  от M до N ---------");
int m = Convert.ToInt32(ReadData("Введите целое число M : "));
int n = Convert.ToInt32(ReadData("Введите целое число N : "));
int sum = 0;
sum = RecursionFun(m, n, sum);




