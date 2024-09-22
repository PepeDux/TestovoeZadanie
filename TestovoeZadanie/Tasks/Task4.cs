using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie
{
    // Класс для задачи 4: Сумма строки пирамиды чисел
    public static class Task4
    {
        public static int RowSum(int rowIndex)
        {
            int firstNumber = rowIndex * (rowIndex - 1) + 1;
            int sum = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                sum += firstNumber + (i * 2);
            }

            return sum;
        }
    }
}
