using System;

namespace Lab02_3_02_
{
    class Program
    {
        static int Min_abs(int[] a, int n)
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
            return m;
        }

        static int Sum(int[] a, int n)
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
            int min = -100, max = 100;
            Random realRnd = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = realRnd.Next(min, max + 1);
               
            }
            min_abs = Min_abs(a, n);
            sum = Sum(a, n);
            Console.WriteLine("номер мiнiмального за модулем елемента масиву {0} ", min_abs + 1);
            Console.WriteLine(" суму елементiв масиву, розташованих мiж першим й останнiм додатними елементами = {0} ", sum);
        }
    }
}
