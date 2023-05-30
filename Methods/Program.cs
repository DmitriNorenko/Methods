using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(string Name, string[] Dishes) User;
            //Console.WriteLine("Введите имя: ");
            //User.Name = Console.ReadLine();
            //User.Dishes = new string[5];
            //for (int i = 0; i < User.Dishes.Length; i++)
            //{
            //    Console.WriteLine($"Введите {i + 1} любимое блюдо: ");
            //    User.Dishes[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Вас зовут: {0}", User.Name);
            //foreach (var dishes in User.Dishes)
            //{
            //    Console.WriteLine("Ваши любимые блюда: " + dishes);
            //}
            ///////////////////////////

            ////////////////////////////////
            //(string name, int age) anketa;

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);
            //Console.ReadKey();
            //int[] array = GetArrayFromConsole();
            //string[] favcolors = new string[3];
            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    favcolors[i] = ShowColor(anketa.name, anketa.age);
            //}
            //foreach (string favcolor in favcolors)
            //{
            //    Console.WriteLine(favcolor);
            //}
            ////////////////////////////////////////////
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            //ChangeAge(ref age);
            //Console.WriteLine(age);
            int num = 10;
            int[] sortedarray = GetArrayFromConsole(ref num);
            ShowArray(sortedarray, true);
            //int num1 = 4, num2 = 4, num3 = 0, num4 = 4;
            //SumNumbers(out num1, ref num2, num3, num4);
            Console.ReadKey();
        }
        static string ShowColor(string Name, int age)
        {
            Console.WriteLine("{0} {1} год\n Напишите свой любимый цвет на английском с маленькой буквы", Name, age);
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static void SortArray(int[] Result, out int[] sortedDesc, out int[] sortedAsc)
        {
            sortedAsc = SortArrayAsc(Result);
            sortedDesc = SortArrayDesc(Result);
        }
        static int[] SortArrayAsc(int[] Result)
        {
            int c;
            for (int i = 0; i < Result.Length; i++)
            {
                for (int k = 0; k < Result.Length; k++)
                {
                    if (Result[i] > Result[k])
                    {
                        c = Result[k];
                        Result[k] = Result[i];
                        Result[i] = c;
                    }
                }
            }
            return Result;
        }
        static int[] SortArrayDesc(int[] Result)
        {
            int c;
            for (int i = 0; i < Result.Length; i++)
            {
                for (int k = 0; k < Result.Length; k++)
                {
                    if (Result[i] > Result[k])
                    {
                        c = Result[k];
                        Result[k] = Result[i];
                        Result[i] = c;
                    }
                }
            }
            return Result;
        }
        static void ShowArray(int[] array, bool isSort = false)
        {
            int[] sortedDesc=array;
            int[] sortedAsc=array;
            if (isSort == true)
            {
                SortArray(array, out sortedDesc, out sortedAsc);
            }
            foreach (int num in sortedDesc)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (int num in sortedAsc)
            {
                Console.Write(num + " ");
            }

        }
        static void ChangeAge(ref int age)
        {
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);
        }
        static int SumNumbers(out int num1, ref int num2, int num3, int num4)
        {
            num1 = 0;

            return num3;
        }
    }
}

