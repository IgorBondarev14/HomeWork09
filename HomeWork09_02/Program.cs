// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


long A(long m, long n)
{
    if (m == 0)
        return n + 1;
    if (n == 0 && m > 0)
        return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}
 

Console.Write("Введите первое НЕ отрицательное число: ");
long m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе НЕ отрицательное число: ");
long n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(m, n));
 