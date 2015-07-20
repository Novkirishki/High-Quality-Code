using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Chef
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            //...
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}
