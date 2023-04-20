using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace MVC
{

    class FractionController
    {
        private Fraction model;
        private FractionView view;

        public FractionController(Fraction model, FractionView view)
        {
            this.model = model;
            this.view = view;

            this.view.AddClicked += OnAddClicked;
            this.view.SubtractClicked += OnSubtractClicked;
        }

        //В методе OnAddClicked контроллер использует модель Fraction и значения, введенные пользователем в FractionView, для вычисления суммы двух дробей.
        //Затем контроллер выводит результат сложения в консоль.

        //Аналогично, в методе OnSubtractClicked контроллер использует модель Fraction и значения, введенные пользователем в FractionView, для вычисления разности двух дробей.
        //Затем контроллер выводит результат вычитания в консоль.




        public void OnAddClicked(object sender, EventArgs e)
        {
            Fraction result = model + new Fraction(view.Numerator2, view.Denominator2);
            Console.WriteLine($"Результат сложения: {result.Numerator}/{result.Denominator}");
        }

        public void OnSubtractClicked(object sender, EventArgs e)
        {
            Fraction result = model - new Fraction(view.Numerator2, view.Denominator2);
            Console.WriteLine($"Результат вычитания: {result.Numerator}/{result.Denominator}");
        }

    }
}
