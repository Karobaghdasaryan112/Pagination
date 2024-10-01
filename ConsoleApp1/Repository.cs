using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Repository
    {
        private List<Animal> ?_animals;
        public Repository()
        {
            _animals = new List<Animal>()
            {
                new Animal { Id = 1, Name = "Leo", Species = "Lion", Age = 5, Weight = 190.5, Habitat = "Savannah", IsEndangered = false },
                new Animal { Id = 2, Name = "Ella", Species = "Elephant", Age = 12, Weight = 5000, Habitat = "Forest", IsEndangered = false },
                new Animal { Id = 3, Name = "Tiger", Species = "Tiger", Age = 7, Weight = 300.1, Habitat = "Jungle", IsEndangered = true },
                new Animal { Id = 4, Name = "Bella", Species = "Giraffe", Age = 6, Weight = 800.3, Habitat = "Savannah", IsEndangered = false },
                new Animal { Id = 5, Name = "Charlie", Species = "Zebra", Age = 8, Weight = 450.2, Habitat = "Savannah", IsEndangered = false },
                new Animal { Id = 6, Name = "Max", Species = "Wolf", Age = 5, Weight = 65.5, Habitat = "Forest", IsEndangered = false },
                new Animal { Id = 7, Name = "Oscar", Species = "Panda", Age = 10, Weight = 150.7, Habitat = "Mountain", IsEndangered = true },
                new Animal { Id = 8, Name = "Lucy", Species = "Kangaroo", Age = 4, Weight = 85.2, Habitat = "Outback", IsEndangered = false },
                new Animal { Id = 9, Name = "Milo", Species = "Penguin", Age = 3, Weight = 25.8, Habitat = "Arctic", IsEndangered = false },
                new Animal { Id = 10, Name = "Simba", Species = "Lion", Age = 4, Weight = 175.6, Habitat = "Savannah", IsEndangered = false },
                new Animal { Id = 11, Name = "Rex", Species = "Crocodile", Age = 15, Weight = 1000, Habitat = "Swamp", IsEndangered = false },
                new Animal { Id = 12, Name = "Daisy", Species = "Deer", Age = 9, Weight = 70.4, Habitat = "Forest", IsEndangered = false },
                new Animal { Id = 13, Name = "Finn", Species = "Fox", Age = 6, Weight = 15.9, Habitat = "Forest", IsEndangered = false },
                new Animal { Id = 14, Name = "Rocky", Species = "Bear", Age = 13, Weight = 450, Habitat = "Mountain", IsEndangered = false },
                new Animal { Id = 15, Name = "Chloe", Species = "Cheetah", Age = 6, Weight = 60.7, Habitat = "Savannah", IsEndangered = true },
                new Animal { Id = 16, Name = "Buddy", Species = "Dog", Age = 4, Weight = 20.1, Habitat = "Urban", IsEndangered = false },
                new Animal { Id = 17, Name = "Coco", Species = "Parrot", Age = 3, Weight = 0.9, Habitat = "Rainforest", IsEndangered = false },
                new Animal { Id = 18, Name = "Jack", Species = "Shark", Age = 20, Weight = 1200, Habitat = "Ocean", IsEndangered = false },
                new Animal { Id = 19, Name = "Molly", Species = "Rabbit", Age = 2, Weight = 4.5, Habitat = "Meadow", IsEndangered = false },
                new Animal { Id = 20, Name = "Lola", Species = "Lemur", Age = 5, Weight = 3.2, Habitat = "Island", IsEndangered = true }
            };
        }
        public List<Animal> ?GetAnimals { get => _animals; }
        
    }
}
