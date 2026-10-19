using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабороторная_работа
{
    internal class Program
    {
           class Rectangle
        { 
            // Открытые поля для хранения данных о высоте и ширине
            public float Height;
            public float Width;

            // Метод — показать на экране данные о прямоугольнике
            public void Show()
            {
                Console.WriteLine("Прямоугольник: высота = {0}, ширина = {1}", Height, Width);
            }

            // Метод — рассчитывает и возвращает периметр прямоугольника
            // P = 2 * высоту + 2 * ширину
            public float Perimetr()
            {
                return 2 * Height + 2 * Width;
            }
            static void Main(string[] args)
            {
                // Корректное отображение русских букв в консоли
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // 1. Создать объект класса Rectangle
                Rectangle rect = new Rectangle();

                // 2. Задать значения полям: высота = 2, ширина = 3
                rect.Height = 2;
                rect.Width = 3;

                // 3. Вывести на экран данные объекта
                rect.Show();

                // 4. Рассчитать периметр и вывести его на экран
                Console.WriteLine("Периметр прямоугольника = {0}", rect.Perimetr());

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
        
    }
}