using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallies_opdracht
{
    internal class Program
    {
        static void Main(String[] args)
        {


            WaterStone waterStone = new WaterStone();
            waterStone.WaterStonePV();
        }
        /*

        List<Klant> KlantenList = new List<Klant>();


        Klant Klant1 = new Klant(1, "Big Smoke", "BScluckin@bell.com", "Number9", "01-01-1992");
        Klant1.PrintKlantInfo();

        KlantenList.Add(Klant1);



        foreach(Klant klant in KlantenList)
        {
            klant.PrintKlantInfo();
        }


    }



        Opdracht2 opdracht = new Opdracht2();
        opdracht.Opdracht();




        List<Car> carList = new List<Car>();

        Car car1 = new Car("Agila", "Opel", 5);
        Car car2 = new Car("RS6 Avant", "Audi", 5);

        carList.Add(car1);
        carList.Add(car2);

        foreach(Car car in carList)
        {
            car.PrintCarInfo();
        }



        private static string _weaponName = "Goude Prikker";
        static void Main(string[] args)
        {

            Opdracht9 weapon1 = new Opdracht9(_weaponName, 10);
            Opdracht9 weapon2 = new Opdracht9("pew pew", 2);
            Opdracht9 weapon3 = new Opdracht9("Pikachu", 55);
            Opdracht9 weapon4 = new Opdracht9("Carl Johnson", 69);

            weapon1.showStats();
            weapon1.UpgradeItem();

            weapon2.showStats();
            weapon2.UpgradeItem();

            weapon3.showStats();
            weapon3.UpgradeItem();

            weapon4.showStats();
            weapon4.UpgradeItem();




            Console.WriteLine("Hoe heet je?");
            string input = Console.ReadLine();
            Console.WriteLine("en hoe oud ben je?");
            string input1 = Console.ReadLine();
            Console.WriteLine("Hoi " + input + ", je bent " + input1 + " jaar oud!");
            */


    }
}