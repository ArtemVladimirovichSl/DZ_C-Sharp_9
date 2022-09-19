// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int sumTo (int M, int N, int sum)
{   
    if (M == N) return N;
    if (M < N) return N + sumTo(M, N - 1, sum);
    else if (M > N) return N + sumTo(M, N + 1, sum);
    return sum;
}
if(M <= N) Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sumTo(M, N, sum)}");
if(M > N) Console.WriteLine($"Сумма натуральных элементов в промежутке от {N} до {M} = {sumTo(M, N, sum)}");