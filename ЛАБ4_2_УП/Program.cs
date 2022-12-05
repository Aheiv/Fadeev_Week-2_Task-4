using System;

namespace ЛАБ4_2_УП
{
    class Program
    {
        static void perevod(int i, ref string s)
        {
            if (i > 0)
            {
                perevod(i / 2, ref s);
                s += (i % 2).ToString();
            }
            if (i == 0)
            {
                s = "0";
            }
            if (i < 0)
            {
                s = Convert.ToString(i, 2);
            }
        }
        static void Main(string[] args)
        {
            int val_10;
            Console.Write("Введите число для перевода в двоичную систему: ");
            while (!int.TryParse(Console.ReadLine(), out val_10))
                Console.Write("Некорректный ввод данных!\nВведите число для перевода в двоичную систему: ");
            string val_2 = "";
            perevod(val_10, ref val_2);
            Console.Write("Ваше число в двоичной системе: " + val_2);

        }
    }
}
