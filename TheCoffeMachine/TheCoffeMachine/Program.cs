using System;
namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMilk milk = new CoffeMilk(400);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);

            Console.WriteLine("Coffee Machine!\n");
            Console.WriteLine("Pilihan : ");
            Console.WriteLine("a. Espresso");
            Console.WriteLine("b. Cappucino");
            Console.Write("Masukan pilihan : ");
            char order = char.Parse(Console.ReadLine());

            if (order == 'a')
            {
                Console.WriteLine("\ncheck " + yummyCoffe.checkAvailability());
                String result = yummyCoffe.makeEsspresso();
                Console.WriteLine("result " + result);
            }

            if (order == 'b')
            {
                Console.WriteLine("check " + yummyCoffe.checkAvailability());
                String result = yummyCoffe.makeCappucino();
                Console.WriteLine("result " + result);
            }

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
        }
    }
}
