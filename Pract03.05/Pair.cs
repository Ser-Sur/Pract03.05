using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;

// Создать класс Pair (пара чисел). Создать необходимые методы и свойства. Определить методы метод сложения полей и 
// операцию сложения пар (а, b) + (с, d) = (а + c, b + d). Создать перегруженные методы для увеличения полей на 1,
// сложения трех пар чисел.

namespace Pract03._05
{
    class Pair
    {
        int _a;
        int _b;

        public int A { get; set; }
        public int B { get; set; }

        /// <summary>
        /// Пара чисел
        /// </summary>
        public Pair()
        {
            A = 1;
            B = 1;
        }
        /// <summary>
        /// Пара чисел с параметрами
        /// </summary>
        /// <param name="a">Параметр 1</param>
        /// <param name="b">Параметр 2</param>
        public Pair(int a, int b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Сумма двух пар
        /// </summary>
        /// <param name="pair1">Пара 1</param>
        /// <param name="pair2">Пара 2</param>
        /// <returns></returns>
        static public Pair Sum(Pair pair1, Pair pair2)
        {
            Pair pair3 = new Pair();
            pair3.A = pair1.A + pair2.A;
            pair3.B = pair1.B + pair2.B;
            return pair3;
        }
        /// <summary>
        /// Сумма трёх пар
        /// </summary>
        /// <param name="pair1">Пара 1</param>
        /// <param name="pair2">Пара 2</param>
        /// <param name="pair3">Пара 3</param>
        /// <returns></returns>
        static public Pair Sum(Pair pair1, Pair pair2, Pair pair3)
        {
            Pair pair4 = new Pair();
            pair4.A = pair1.A + pair2.A + pair3.A;
            pair4.B = pair1.B + pair2.B + pair3.B;
            return pair4;
        }

        /// <summary>
        /// Плюс 1
        /// </summary>
        public void AddOne()
        {
            _a++;
            _b++;
        }
        /// <summary>
        /// Плюс 1 к конкретной паре
        /// </summary>
        /// <param name="pair1">Конкретная пара</param>
        static public void AddOne(ref Pair pair1)
        {
            pair1.A++;
            pair1.B++;
        }

        public static Pair operator --(Pair pair1)
        {
            pair1.A--;
            pair1.B--;
            return pair1;
        }
    }
}
