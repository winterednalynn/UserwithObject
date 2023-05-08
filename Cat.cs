using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace UserwithObject
{
    internal class Cat : Dog
    {
        bool _Humanfriend;
        public Cat(string kindOfAnimal, string colorOfAnimal, int numOflegs, bool isHumanCampanion) : base(kindOfAnimal, colorOfAnimal, numOflegs, isHumanCampanion)
        {

        }
        public override bool Campanion() // Overriding b/c lets me change the bool 
        {
            if (_Humanfriend == true)
            {
                Console.WriteLine("This animal is qualified as a human campanion"); ;
            }
            return true;
      
           
        }
        public new void Sound()
        {
            Console.WriteLine("I am a cat: Purr Purr, Meow Meow");
        }
        public override string ToString()
        {
            return $"{Campanion()} " + base.ToString();
        }
    }
}
