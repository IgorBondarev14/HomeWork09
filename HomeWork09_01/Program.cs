// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int sum(int n, int m, int result)
{
    if (m > n)
        return result;
    result = result + m;
    return sum(n, m + 1, result);
}


Console.Write("Введите начальное значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.Write("Сумма элементов равна: ");
Console.WriteLine(sum(n, m, result));
