using System;

namespace ЛАБ4_УП
{
    class Program
    {
        static double func (int n, double sum, int N)
        {
            if (n == 1)
            {
                sum = (n + Math.Sqrt(sum));
                return N / Math.Sqrt(sum);
            }
            if (n == N) sum = n;
            else
            {
                sum = (n + Math.Sqrt(sum));
            }
            n--;
           
            return func(n, sum, N);
        }
        static void Main(string[] args)
        {
            int N;
            double f;
            Console.Write("Введите число N: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                Console.Write("Некорректный ввод данных!\nВведите число N: ");
            f = func(N, 0, N);
            Console.WriteLine("F(" + N + ") = " + f);
        }
    }
}
