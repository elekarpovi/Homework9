// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(5);
int n = rnd.Next(5);

Console.WriteLine($"Число m = {m}, число n = {n}.");

int Akk(int m, int n)
{
    if(m==0) return n+1;
    if(n==0 && m!=0) return Akk(m-1, 1);
    else return Akk(m-1, Akk(m, n-1));
}
Console.WriteLine($"Результат вычисления функции Аккермана: {Akk(m, n)}");
