using System;
using ClassLibrary;

namespace TMS.Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport BYPass = new Passport(1996,123456,"Выдан Московским РУВД", DateTime.Today, true);
            Console.WriteLine(BYPass.IssuedDate);
            int[,] array = new int[,] { { 1, 2, 3 }, { 3,4, 5 } };
            IOHelper.PrintArray(array);

            Monster PU = new Monster("Пу", MonsterType.orc, 200,400,5,85,"Трололо","Ойойой");
            Monster LU = new Monster("Лу", MonsterType.undead, 100, 300, 3, 85, "Тралала", "Айяйяй");
            Console.WriteLine(PU.GetInfo);
        }
    }
}
