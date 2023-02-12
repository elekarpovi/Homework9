// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int RecursSum(int m, int n)
{
    if (m == n) return m;
    if (m < 0 && n < 0) return 0;
    if (m < 0) return n + RecursSum(0, --n);
    if (n < 0) return m + RecursSum(0, --m);
    else return n + RecursSum(m, --n);
}
System.Console.Write($"Сумма натуральных элементов в промежутке от M до N = {RecursSum(m,n)}");
