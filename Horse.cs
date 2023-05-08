using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserwithObject
{
    internal class Horse : Animal
    {
        bool _isPet;
        Trainer _trainer;
        public Horse(string kindOfAnimal, string colorOfAnimal, int numOflegs, bool isPet, Trainer trainer) : base(kindOfAnimal, colorOfAnimal, numOflegs)
        {
            _isPet = isPet;
            _trainer = trainer;
        }

        public bool IsPet { get => _isPet; set => _isPet = value; }

        public bool isApet()
        {
            Console.WriteLine("I am not considered a pet."); // Horse is not considered as a pet. 
            return false; 
        }
        public new void Sound()
        {
            Console.WriteLine("I am a horse, 'Snort, Squeal' ");
        }

        public override string ToString()
        {
            return $"{isApet()} " + base.ToString();
        }
    }
}
