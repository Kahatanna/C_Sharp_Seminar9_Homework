/*

Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
(с помощью рекурсии)

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

*/

string PrintNumbers(int m, int n)
{
    return (n == m ? n.ToString() : m + ", " + PrintNumbers(m + 1, n));
}

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());


Console.WriteLine(PrintNumbers(m, n));