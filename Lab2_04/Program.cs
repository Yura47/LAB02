using System;

namespace Lab2_04
{

    public class Program
    {
        static public int Min_abs(int[] a, int n)
        {
            int m = 0;
            int min_abs = Math.Abs(a[0]);
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(a[i]) < min_abs)
                {
                    min_abs = Math.Abs(a[i]);
                    m = i;

                }
            }
            return m+1;
        }

        static public int Sum(int[] a, int n)
        {
            int sum = 0;
            int p = 0;
            int l = 0;
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    p++;
                    l = i;
                }
                if (p == 1)
                {
                    m = i;
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (m < j && j <= l - 1)
                {
                    sum += a[j];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int min_abs = 0, sum = 0;
            Console.WriteLine("введiть кiлькiсть елементiв одновимiрного масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool some = true;
                while (some)
                {
                    Console.Write("Введiть елемент одновимiрного масиву,a[{0}]=", i);
                    string S1 = Console.ReadLine();
                    if (double.Parse(S1) % 1 == 0)
                    {
                        a[i] = int.Parse(S1);
                        some = false;
                    }
                    else
                    {
                        Console.WriteLine("Введiть цiле число");
                    }
                }
            }
            min_abs = Min_abs(a, n);
            sum = Sum(a, n);
            Console.WriteLine("номер мiнiмального за модулем елемента масиву {0} ", min_abs );
            Console.WriteLine(" суму елементiв масиву, розташованих мiж першим й останнiм додатними елементами = {0} ", sum);
        }
    }
}
