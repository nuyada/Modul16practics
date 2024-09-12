using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul16practics
{
    //Класс калькулятор
    public class Calculator
    {
        /// <summary>
        /// Метод для суммы 2 чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Метод для вычитания 2 чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Метод для умножения 2 чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Метод для деления 2 чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
