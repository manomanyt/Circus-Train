using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrain.Domain
{
    
    public class Animal
    {
        public enum Size
        {
            Small = 1,
            Medium = 3,
            Large = 5
        }
        public enum Diet
        {
            Carnivore,
            Herbivore
        }
        public Size AnimalSize { get; set; }
        public Diet AnimalDiet { get; set; }

        public Animal(Size size, Diet diet)
        {
            AnimalSize = size;
            AnimalDiet = diet;
        }
    }
}
