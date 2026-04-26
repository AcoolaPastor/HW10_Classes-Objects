using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных
//значений, а также метод ToRadians для перевода угла в радианы.
//Создать объект на основе разработанного класса.
//Осуществить использование объекта в программе.

namespace HW10_Classes_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grad, min, sec;
            Angle angle;

            do
            {
                Console.WriteLine("Введите число в формате градус° минута' секунда\":");
                grad = Convert.ToInt32(Console.ReadLine());
                min = Convert.ToInt32(Console.ReadLine());
                sec = Convert.ToInt32(Console.ReadLine());
                angle = new Angle(grad, min, sec);
            } while (angle.isCorrect == false);

            Console.WriteLine($"Входное значение:\n{grad}° {min}' {sec}\"");
            double rad = angle.toRadian();
            //double radTested = (grad + min / 60.0 + sec / 3600.0) * Math.PI / 180.0;
            Console.WriteLine($"Значение в радианах:\n{rad:F4}");

        }
    }
}
