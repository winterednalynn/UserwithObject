using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UserwithObject
{//EDNA LYNN LAXA 
 //PROGRAMMING III
 //USERS W/ OBJECTS 
 //MAY 7 , 2023 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Trainer dogTrainer = new Trainer();// Has Relationship w/ Dog 
            string dogOwner = dogTrainer._kindOfTrainer = "Owner of Dog"; // Giving Value to dogOwner from accessing Trainer class 

            Dog dog = new Dog("German Sheperd Dog", "Black & White", 4, true); //Inherits from Animal (super class) 
            Console.WriteLine(dog.ToString()); //Displaying base to string 
            Console.WriteLine($"Dogs are trained by {dogOwner}"); // Displaying Trainer 
            dog.Sound(); // Displaying Dog's Sound / Behavior .

            Console.WriteLine();// SPACING 

            Trainer catTrainer = new Trainer(); // Has relationship w/ Cat 
            string catOwner = catTrainer._kindOfTrainer = "Owner of Cat"; //Giving Value to catOwner from accessing Trainer class 

            Cat cat = new Cat("Balinese-Javanese", "White", 4, true); //Cat constructor inherits from dog vs animal 
            Console.WriteLine(cat.ToString()); //Prompts a method calling of Campanion & base to string 
            Console.WriteLine($"Cats are trained by {catOwner}"); // Displaying Trainer 
            cat.Sound(); // Displaying Cat Sound / Behavior. 

            Console.WriteLine(); // SPACING 

            Trainer cowboy = new Trainer(); //Has a relationship w/ Horse 
           string trainer=cowboy._kindOfTrainer = "Cowboy"; //Giving Value to horse Trainer from accessing Trainer class 

            Horse horse = new Horse("American Paint", "White with Brown Spots", 4, false, cowboy); // Constructor from Animal Class. 
            Console.WriteLine(horse.ToString()); // Prompt a method that is called through Horse class & base.Tostring 
            Console.WriteLine($"Trained by {trainer}"); //Displaying value Trainer 
            horse.Sound(); //Calling horse sound through horse class. 

            Console.WriteLine();
            Console.WriteLine();

            //ATTEMPTING Containment 
            List<Animal> animals = new List<Animal>();

            animals.Add(dog);
            animals.Add(cat);
            animals.Add(horse);

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
