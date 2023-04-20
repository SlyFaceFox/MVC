using System;
namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты Fraction, FractionView и FractionController
            Fraction fraction1 = new Fraction(3, 4);
            FractionView fractionView = new FractionView(fraction1);
            FractionController fractionController = new FractionController(fraction1, fractionView);

            // Выводим дробь на консоль
            fractionView.Render();

            // Выполняем операцию сложения дробей и выводим результат на консоль
            Console.WriteLine("Сложение дробей:");
            fractionController.OnAddClicked(null, null);

            // Выполняем операцию вычитания дробей и выводим результат на консоль
            Console.WriteLine("Вычитание дробей:");
            fractionController.OnSubtractClicked(null, null);

            Console.ReadLine();
        }
    }
}