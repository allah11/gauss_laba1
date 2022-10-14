            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;


namespace Gauss
    {
        public class Gauss
        {
         public static void Gauss_1(int n, double[,] a, double[] b) // функция нахождения СЛАУ по Гаусу первая часть
        {
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }
                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }
        }
        public static void Gauss_2(int n, double s, double[,] a, double[] b, double[] x) // функция нахождения СЛАУ по Гаусу вторая часть
        {
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + a[k, j] * x[j];
                x[k] = (b[k] - s) / a[k, k];
            }
        }
            static void Main(string[] args)
            {
                double s = 0;
                int n = 0; //размерность системы
                n = int.Parse(Console.ReadLine());
                double[,] a = new double[n, n];
                double[] b = new double[n];
                double[] x = new double[n];

                for (int i = 0; i < n; i++) // подготовка значений

                    x[i] = 0;
                Console.WriteLine("Введите построчно коэффициенты системы:");

                for (int i = 0; i < n; i++) // цикл записи значений по X
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = double.Parse(Console.ReadLine());
                    }

                Console.WriteLine("Введите свободные коэффициенты:");
                for (int i = 0; i < n; i++) // цикл записи значений по Y
                    b[i] = double.Parse(Console.ReadLine());

                    Gauss_1(n,a,b);
                                            // расчет СЛАУ
                    Gauss_2(n, s, a, b, x);

                Console.WriteLine("Система имеет следующие корни");
                for (int i = 0; i < x.Length; i++) // цикл вывода получившихся значений
                {
                    Console.WriteLine($"x{i} = {x[i]:0.##}");
                }
                Console.ReadLine();
            }
        }
    }