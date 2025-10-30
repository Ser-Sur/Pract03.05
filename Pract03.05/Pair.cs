using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Effects;

// Использовать класс Pair (пара чисел). Разработать операцию сложения пар (а, b) +
// (с, d) = (а + c, b + d). Разработать операцию для уменьшения полей на 1.

namespace Pract03._05
{
    class Pair
    {
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
        /// Сложение пар
        /// </summary>
        /// <param name="pair1">Пара 1</param>
        /// <param name="pair2">Пара 2</param>
        /// <returns>Итоговая пара</returns>
        public static Pair operator +(Pair pair1, Pair pair2)
        {
            Pair pair3 = new Pair();
            pair3.A = pair1.A + pair2.A;
            pair3.B = pair1.B + pair2.B;
            return pair3;
        }

        /// <summary>
        /// Плюс 1 к паре
        /// </summary>
        /// <param name="pair1">Пара</param>
        /// <returns>Пара</returns>
        public static Pair operator ++(Pair pair1)
        {
            pair1.B++;
            pair1.A++;
            return pair1;
        }

        /// <summary>
        /// Минус 1 к паре
        /// </summary>
        /// <param name="pair1">Пара</param>
        /// <returns>Пара</returns>
        public static Pair operator --(Pair pair1)
        {
            pair1.A--;
            pair1.B--;
            return pair1;
        }
    }
}
