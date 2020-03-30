using System;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private CoffeMilk coffeMilk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, CoffeMilk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.coffeMilk = milk;
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffeMilk.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.coffeMilk.makeOneCup();
            return "Yey! your Cappucino coffe is ready\n";
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your Esspresso coffe is ready\n";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()}, the coffe powder : {this.coffePowder.getNetto()} , and the milk : {this.coffeMilk.getIsi()}";
        }
    }
}
