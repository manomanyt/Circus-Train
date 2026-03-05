using CircusTrain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrain.BLL
{
    public class WagonService
    {
        public bool AddAnimalToWagon(Animal newAnimal, Wagon wagon)
        {
            if (wagon.CurrentPoints + (int)newAnimal.AnimalSize > wagon.MaxPoints)
            {
                return false;
            }
            foreach (Animal existingAnimal in wagon.Animals)
            {
                if (newAnimal.AnimalDiet == Animal.Diet.Carnivore && newAnimal.AnimalSize >= existingAnimal.AnimalSize)
                {
                    return false;
                }
                if (existingAnimal.AnimalDiet == Animal.Diet.Carnivore && existingAnimal.AnimalSize >= newAnimal.AnimalSize)
                {
                    return false;
                }
            }
            wagon.Animals.Add(newAnimal);
            return true;
        }
    }
}
