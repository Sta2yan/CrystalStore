using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userMoney = 100;
            int userCrystal = 0;
            int priceCrystal = 10;
            int countBuyCrystal;

            Console.Write("Введите кол-во кристаллов, которое хотели бы купить: ");
            countBuyCrystal = Convert.ToInt32(Console.ReadLine());

            userMoney -= priceCrystal * countBuyCrystal;
            userCrystal += countBuyCrystal;

            Console.WriteLine($"\nДеньги: {userMoney}" +
                              $"\nКристаллы: {userCrystal}");
        }
    }
}