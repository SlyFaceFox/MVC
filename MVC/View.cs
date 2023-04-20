using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC
{
    class FractionView
    {
        //Свойства Numerator2 и Denominator2 содержат введенные пользователем значения для второй дроби, которые используются контроллером для выполнения операций.
        private Fraction model;
        public int Numerator1 { get; set; }
        public int Denominator1 { get; set; }
        public int Numerator2 { get; set; }
        public int Denominator2 { get; set; }

        public FractionView(Fraction model)
        {
            this.model = model;
            Numerator1 = model.Numerator;
            Denominator1 = model.Denominator;
        }

        public event EventHandler AddClicked;
        public event EventHandler SubtractClicked;

        //Метод Render() отображает дробь на экране в виде числитель / знаменатель.
        public void Render()
        {
            Console.WriteLine($"Первая дробь: {Numerator1}/{Denominator1}");
            Console.WriteLine("Введите данные для второй дроби:");
            Console.Write("Числитель: ");
            Numerator2 = int.Parse(Console.ReadLine());
            Console.Write("Знаменатель: ");
            Denominator2 = int.Parse(Console.ReadLine());
        }

        public void OnAddClicked()
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }

        public void OnSubtractClicked()
        {
            SubtractClicked?.Invoke(this, EventArgs.Empty);
        }
    }


}
