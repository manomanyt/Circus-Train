using CircusTrain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrain.BLL
{
    public class AnimalService
    {
        public List<Animal> GenerateRandomAnimal()
        {
            List<Animal> animals = new List<Animal>();
            Random random = new Random();
            int numberOfAnimals = random.Next(10, 25);
            Array sizes = Enum.GetValues(typeof(Animal.Size));
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Animal.Size size = (Animal.Size)sizes.GetValue(random.Next(sizes.Length));
                Animal.Diet diet = (Animal.Diet)random.Next(0, 2);
                animals.Add(new Animal(size, diet));
            }
            return animals;
        }
        
    }
}
