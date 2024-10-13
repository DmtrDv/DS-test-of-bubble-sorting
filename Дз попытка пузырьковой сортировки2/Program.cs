using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_попытка_пузырьковой_сортировки2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 4, 9, 2, 5, 1, 11 }; //создал список
            Console.WriteLine("До сортировки: ");
            for (int i = 0; i < list.Count; i++) //создал цикл показывающий цифры до сортировки
            {
                Console.WriteLine(list[i]);
            }

            int dopVariable; //добавил дополнительную переменную
            for (int a = 0; a < list.Count; a++)
            {
                for (int b = a + 1; b < list.Count; b++)
                {
                    if (list[a] > list[b])
                    {
                        dopVariable = list[a];
                        list[a] = list[b];
                        list[b] = dopVariable;
                    }
                }
            }
            Console.WriteLine("После сортировки: ");
            for (int i = 0; i < list.Count; i++) //создал цикл показывающий цифры после сортировки
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
            return;
        }
    }
}
