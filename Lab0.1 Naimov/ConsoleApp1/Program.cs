using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение в радианах: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double radians))
        {
            double pi = Math.PI;

            double degrees = radians * (180 / pi);

            Console.WriteLine($"{radians} радианов = {degrees} градусов");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число в радианах.");
        }
    }
}