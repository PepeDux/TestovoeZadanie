using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie
{
    // Класс для задачи 5: Три варианта, которые всегда возвращают 5
    public static class Task5
    {
        // Вариант 1: Использование длины строки
        public static int AlwaysFive_1()
        {
            return "Hello".Length;
        }

        // Вариант 2: Использование длины массива булевых значений
        public static int AlwaysFive_2()
        {
            return new bool[] { true, true, true, true, true }.Length;
        }

        // Вариант 3: Использование перечисления
        public enum MyEnum
        {
            A, B, C, D, E
        }

        public static int AlwaysFive_3()
        {
            return Enum.GetValues(typeof(MyEnum)).Length;
        }
    }
}
