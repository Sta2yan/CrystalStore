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
            int myMoney = 100;
            int myCrystal = 0;
            int priceCrystal = 10;
            int countBuyCrystal;

            Console.Write("Введите кол-во кристаллов, которое хотели бы купить: ");
            countBuyCrystal = Convert.ToInt32(Console.ReadLine());

            myMoney -= priceCrystal * countBuyCrystal;
            myCrystal += countBuyCrystal;

            Console.WriteLine($"\nДеньги: {myMoney}" +
                              $"\nКристаллы: {myCrystal}");
        }
    }
}