using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    { 
            public int Id { get; set; }
            public string ?Name { get; set; }
            public string ?Species { get; set; }
            public int Age { get; set; }
            public double Weight { get; set; }
            public string ?Habitat { get; set; }
            public bool IsEndangered { get; set; }

        public Animal(string Name,string Species,int Age,double Weight,string Habitat,bool IsEndangered) 
        {
            this.Name = Name;
            this.Species = Species;
            this.Age = Age;
            this.Weight = Weight;
            this.Habitat = Habitat;
            this.IsEndangered = IsEndangered;
        }
        public Animal() { }
    }
}
