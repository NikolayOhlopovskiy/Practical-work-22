using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    /// <summary>
    /// Class описывающий вычисления.
    /// </summary>
    class Calculate
    {
       public double field1;
       public double field2;
        /// <summary>
        /// Конструктор без параметров(по умолчанию)
        /// </summary>
        public Calculate() { }
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="Поля1"></param>
        public Calculate(double field1)
        {
            this.field1 = field1;

        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="Поля2"></param>
        public Calculate (double field1,double field2) :this(field1)
        {
            this.field2 = field2;
        }
        /// <summary>
        /// Функция формирования строки с информацией об объекте.
        /// </summary>
        
        public void Output1() // вариант 1 
        {
            Console.WriteLine($"field1 = {field1}\t field2 = {field2}\t корень: {Func()} ");
        }
        public override string ToString() //вариант 2
        {
            return $"field1 = {field1}\t field2 = {field2} корень: {Func()}";
        }
        /// <summary>
        /// Функция обработки значений полей: вычислить корень квадратный из произведения чисел.
        /// </summary>
        public double Func()
        {
            return Math.Sqrt(field1 * field2);
        }
    }
}
