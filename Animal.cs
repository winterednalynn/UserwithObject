using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserwithObject
{
    class Animal //SUPER CLASS 
    {
        string _kindOfAnimal;
        string _colorOfAnimal;
        int _numOflegs;

        public Animal(string kindOfAnimal, string colorOfAnimal, int numOflegs)
        {
            _kindOfAnimal = kindOfAnimal;
            _colorOfAnimal = colorOfAnimal;
            _numOflegs = numOflegs;
        }

        public string KindOfAnimal { get => _kindOfAnimal; set => _kindOfAnimal = value; }
        public string ColorOfAnimal { get => _colorOfAnimal; set => _colorOfAnimal = value; }
        public int NumOflegs { get => _numOflegs; set => _numOflegs = value; }

        public void Sound()
        {
            Console.WriteLine("I am here, roar.");
        }

        public override string ToString()
        {
            return $"Kind of Animal {_kindOfAnimal} - Color of Animal {_colorOfAnimal} - Number Of Legs {_numOflegs}"; 
        }
    }
}
