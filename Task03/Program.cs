/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29


A(2, 5), A(1, 2)
A(m, n) = n + 1, если m = 0,
        = A(m - 1, 1), если m > 0, n = 0,
        = A(m - 1, A(m, n - 1)), если m > 0, n > 0.

*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
            if (result < 0)
            {
                Console.Clear();
                Console.WriteLine("Число должно быть неотрицательным. Введите корректное число.");
            }
            else
                break;
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }


    return result;
}

double Ackerman(double m, double n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ackerman(m - 1, 1);
        else return Ackerman(m - 1, Ackerman(m, n - 1));
       
    }


int m = GetNumber("Введите неотрицательное число M:");
int n = GetNumber("Введите неотрицательное число N:");

Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} = {Ackerman(m,n)}");

