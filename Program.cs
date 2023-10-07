using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrameLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string s,s3;
            int v = -1, count, z2, N, K;
            int[] array = new int[5];
            while (v != 0)
            {
                Console.Clear();
                Console.WriteLine("2) Задание 2 \n3) Задание 3\n5) Задание 5 \n6) Задание 6 \n\n0) Выход \n\nВведите номер метода : ");
                s = Console.ReadLine();
                v = Convert.ToInt32(s);
                switch (v)
                {
                    case 2:
                        {
                            count = 0;
                            Console.Clear();
                           
                            Console.WriteLine("Поочереди введите числа:");
                            for (int i = 0; i < 5; i++)
                            {
                                s = Console.ReadLine();
                                z2 = Convert.ToInt32(s);
                                array[i] = z2;
                            }

                            for (int i = 0; i < 5; i++)
                            {
                                if (9 < array[i] && array[i] < 100)
                                {
                                    count++;
                                };
                            }
                            Console.WriteLine("Количество двухзначных чисел: " + count);

                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s3 = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите N:");
                            s = Console.ReadLine();
                            N = Convert.ToInt32(s);
                            Console.WriteLine("Введите K:");
                            s = Console.ReadLine();
                            K = Convert.ToInt32(s);
                            Console.WriteLine("---------");
                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine(K);
                            }
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Application.Run(new Form1());
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Application.Run(new Form2());
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                    case 0:
                        {
                            Console.Clear();
                            break;
                        }

                    default:
                        { 
                        Console.Clear();
                        Console.WriteLine("Введено невернрое значение!");
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }
                }
            }
        }
    }
}
