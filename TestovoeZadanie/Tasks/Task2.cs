using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZadanie
{
    // Класс для задачи 2: Размен американской валюты
    public static class Task2
    {
        public static Dictionary<string, int> GetCoinChange(double amount)
        {
            var coins = new Dictionary<string, int>
        {
            {"Quarters", 0},
            {"Dimes", 0},
            {"Nickels", 0},
            {"Pennies", 0}
        };

            if (amount <= 0) return coins;

            int cents = (int)Math.Floor(amount);

            coins["Quarters"] = cents / 25;
            cents %= 25;

            coins["Dimes"] = cents / 10;
            cents %= 10;

            coins["Nickels"] = cents / 5;
            cents %= 5;

            coins["Pennies"] = cents;

            return coins;
        }
    }
}
