using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserwithObject
{
    class Dog : Animal // CHILD 
    {
        bool _isHumanCampanion; // true or false ; pet or not 
        public Dog(string kindOfAnimal, string colorOfAnimal, int numOflegs, bool isHumanCampanion) : base(kindOfAnimal, colorOfAnimal, numOflegs)
        {
            _isHumanCampanion = isHumanCampanion;   
            
        }

        public virtual bool Campanion() // Using virtual to give permission to change 
        {
            if (_isHumanCampanion == true)
            {
                Console.WriteLine("This animal is qualified as a human campanion"); ;
            }
            else
            {

            }
            return true; 
        }
 
      
        public bool IsHumanCampanion { get => _isHumanCampanion; set => _isHumanCampanion = value; }
        public new void Sound()
        {
            Console.WriteLine("I am a dog, Woof Woof");
        }
        public override string ToString()
        {
            return $"{Campanion()} " + base.ToString();
        }
    }
}
