using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie
{
    // Класс для задачи 3: Перестановка цифр числа в порядке убывания
    public static class Task3
    {
        public static long ReorderDigitsDescending(int num)
        {
            return long.Parse(new string(num.ToString().OrderByDescending(c => c).ToArray()));
        }
    }
}
