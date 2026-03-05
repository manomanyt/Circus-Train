using CircusTrain.Domain;
using CircusTrain.BLL;
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        AnimalService animalService = new AnimalService();
        List<Animal> animals = animalService.GenerateRandomAnimal();
        animals = animals.OrderByDescending(a => a.AnimalSize).ThenBy(a => a.AnimalDiet).ToList();
        foreach (var animal in animals)
            {
                Console.WriteLine($"Size:{animal.AnimalSize}  Diet:{animal.AnimalDiet}");
            }
        TrainService trainService = new TrainService();
        List<Wagon> wagonList = new List<Wagon>();
        foreach (Animal animal in animals)
        {
            bool wagonCreated = false;
            foreach (Wagon wagon in wagonList)
            {
                if(wagon.WagonService.AddAnimalToWagon(animal, wagon))
                {

                    wagonCreated = true;
                    break;
                }
            }
            if (!wagonCreated)
            {
                Wagon newWagon = new Wagon();
                if(newWagon.WagonService.AddAnimalToWagon(animal, newWagon))
                {
                    wagonList.Add(newWagon);
                }
            }
        }
        foreach(var wagon in wagonList)
        {
            Console.WriteLine($"Wagon {wagonList.IndexOf(wagon) + 1}:");
            foreach (var animal in wagon.Animals)
            {
                Console.WriteLine($"Size:{animal.AnimalSize}  Diet:{animal.AnimalDiet} Points: {(int)animal.AnimalSize}");
            }
        }
        Console.WriteLine($"Wagons Used:{wagonList.Count}");
    }
}