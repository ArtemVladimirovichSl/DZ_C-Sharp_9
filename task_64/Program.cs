// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string NaturalNum (int M, int N)
{    
    if (M < N) return $"{M} " + NaturalNum(M + 1, N);
    else if (M > N) return $"{M} " + NaturalNum(M - 1, N);
    else return Convert.ToString(M);
}
Console.WriteLine(NaturalNum(M, N));