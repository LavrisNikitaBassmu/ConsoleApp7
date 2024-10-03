using System;

class DigitProduct
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя четырехзначное число
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Вызываем метод CalculateProduct с полученным значением
        CalculateProduct(number);
    }

    static void CalculateProduct(int number)
    {
        // Инициализируем переменную для хранения произведения
        int product = 1;

        // Разбираем число на цифры и умножаем их
        while (number > 0)
        {
            int digit = number % 10;
            product *= digit;
            number /= 10;
        }

        // Выводим результат на консоль
        Console.WriteLine($"Произведение цифр: {product}");
    }
}