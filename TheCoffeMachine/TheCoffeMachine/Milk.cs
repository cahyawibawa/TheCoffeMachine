using System;

namespace TheCoffeMechine
{
    class CoffeMilk
    {
        private int isi = 0;
        private int isiOneCup = 100;

        public CoffeMilk(int isi)
        {
            this.isi = isi;
        }

        public Boolean isAvailable()
        {
            return this.isi >= this.isiOneCup;
        }

        public void makeOneCup()
        {
            this.isi -= isiOneCup;
        }

        public int getIsi()
        {
            return this.isi;
        }
    }
}