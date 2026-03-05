# Circus-Train
Circus Train Assignment from the Fontys University.
The Story:
Circus director Hans needs to transport animals by train to new homes. With expensive wagon rentals, he needs optimal animal distribution while keeping everyone safe.

Requirements
Animal Properties
Diet: Carnivore (meat-eating) or Herbivore (plant-eating)
Size: Small (1 point), Medium (3 points), Large (5 points)
Safety Rules
Carnivores will eat animals of equal or smaller size
Prevent any animal from being eaten!
Wagon Constraints
Each wagon holds a maximum of 10 points
Wagons must be used optimally (no single animal per wagon unless necessary)

My Task
Create a program that:

Accepts different animal types as input
Calculates optimal wagon distribution
Ensures all safety requirements are met
Minimises the number of wagons needed
Includes unit tests proving your algorithm works correctly

The way my solustion works is that the user runs the project and it generates a random amount of animals in random sizes with random diets. The list of animals get sorted by size (large to small) and by diet in alphabetical order. These animals then get added to wagons that get created based on the animals generated, and an algorithm calculates what animal goes in what wagon together with what animal. In the end, the list of animals will be shown aswell as every wagon, which show what animal is in the wagon and how much space it takes up.

Code is a bit messy and can definitely be simplified, but this is one of the first C# assignments that I have had to make.
