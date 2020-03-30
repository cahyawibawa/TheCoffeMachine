using System;

namespace TheCoffeMechine
{
    class WaterGalon
    {
        private int volume = 0;//mililiter
        private int volumeOneCup = 250;

        public WaterGalon(int volume)
        {
            this.volume = volume;
        }

        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }

        public void addWater(int volume)
        {
            this.volume += volume;
        }

        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }
    }
}