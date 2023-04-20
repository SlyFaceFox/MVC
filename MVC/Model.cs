using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
  
    class Fraction
    {
        //Этот код содержит класс Fraction, который представляет дробь с числителем и знаменателем.
        //Класс имеет два свойства Numerator (числитель) и Denominator (знаменатель), и конструктор Fraction, который принимает числитель и знаменатель.
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        //Класс также содержит два оператора: + (сложение) и - (вычитание).
        //Они позволяют складывать и вычитать дроби, используя общий знаменатель, чтобы избежать дробей с разными знаменателями.
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //в классе есть два приватных метода LCM и GCD. LCM возвращает наименьшее общее кратное двух чисел, а GCD возвращает наибольший общий делитель двух чисел.
        //Они используются операторами + и -, чтобы найти общий знаменатель.
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int lcm = LCM(a.Denominator, b.Denominator);
            int newNumerator = a.Numerator * lcm / a.Denominator + b.Numerator * lcm / b.Denominator;
            return new Fraction(newNumerator, lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int lcm = LCM(a.Denominator, b.Denominator);
            int newNumerator = a.Numerator * lcm / a.Denominator - b.Numerator * lcm / b.Denominator;
            return new Fraction(newNumerator, lcm);
        }

        private static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}

