﻿using System;
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
            //string[] favcolors = new string[3];
            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    favcolors[i] = ShowColor();
            //}
            //foreach (string favcolor in favcolors)
            //{
            //    Console.WriteLine(favcolor);
            //}
            var array = GetArrayFromConsole();
            foreach (int num in GetArrayFromConsole())
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            int c = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int k = 0; k > result.Length; k++)
                {
                    if (result[i] > result[k])
                    {
                        c = result[k];
                        result[k] = result[i];
                        result[i] = c;
                    }
                }
            }
            return result;
        }
    }
}
