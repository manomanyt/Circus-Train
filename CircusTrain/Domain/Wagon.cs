using CircusTrain.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrain.Domain
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }
        public int MaxPoints { get; set; }
        public WagonService WagonService { get; set; }
        public bool IsSpecial { get; set; }
        public int CurrentPoints
        {
            get
            {
                int points = 0;
                foreach (var animal in Animals)
                {
                    points += (int)animal.AnimalSize;
                }
                return points;
            }
        }
        public Wagon()
        {
            Animals = new List<Animal>();
            MaxPoints = 10;
            WagonService = new WagonService();
        }
    }
}
