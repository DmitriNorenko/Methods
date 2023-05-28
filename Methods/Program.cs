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
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} любимое блюдо: ");
                User.Dishes[i] = Console.ReadLine();
            }
            Console.WriteLine("Вас зовут: {0}", User.Name);
            foreach (var dishes in User.Dishes)
            {
                Console.WriteLine("Ваши любимые блюда: " + dishes);
            }
            Console.ReadKey();
        }
    }
}
