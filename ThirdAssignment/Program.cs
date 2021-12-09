using System;
using System.Collections.Generic;

namespace ThirdAssignment
{
    class Program
    {       
        static void TryDifferentPersons()
        {
            IPersonHandler personHandler = new IPersonHandler();
            try
            {
                Person person = personHandler.CreatePerson(20, "Jim", "Smith", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(20, "JimLongFirstNameWhichIsNotCorrect", "Smith", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(20, "J", "Smith", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(20, "", "Smith", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }
            try
            {
                Person person = personHandler.CreatePerson(20, "Jim", "", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(-1, "Jim", "Smith", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(20, "Jane", "Smith", 155, 50);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

            try
            {
                Person person = personHandler.CreatePerson(20, "Jim", "TooLongIsMyLastNameToBeTrueOrValidOrCorrect", 160, 55);
                Console.WriteLine(personHandler.ShowDetails(person));

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error. {e.Message}");
            }

        }

        static void CreateVariousAnimals()
        {
            Animal horse = new Horse("horsee", 80, 10, 70);
            Animal dog = new Dog("dogee", 30, 10, "Bulldog");
            Animal hedgeHog = new Hedgehog("hedgee", 20, 5, 100);
            Animal worm = new Worm("Mr worm", 0.25, 1, true);
            Animal bird = new Bird("Birdy", 1.5, 1, 10.5);
            Animal wolf = new Wolf("Wolfie", 55, 10, 30);

            List<Animal> animalList = new List<Animal>();
            animalList.Add(horse);
            animalList.Add(dog);
            animalList.Add(hedgeHog);
            animalList.Add(worm);
            animalList.Add(bird);
            animalList.Add(wolf);

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
            }
        }

        static void CreateVariousBirds()
        {
            Bird flamingo = new Flamingo("flamingo1", 1.5, 1, 3, 2);
            Bird pelican = new Pelican("pelican1", 15, 2, 5, Utils.BirdColor.Blue);
            Bird swan = new Swan("swan1", 3, 5, 6, 2.2);

            List<Bird> birdList = new List<Bird>();
            birdList.Add(flamingo);
            birdList.Add(pelican);
            birdList.Add(swan);

            foreach (Bird bird in birdList)
            {
                Console.WriteLine(bird.Stats());
                bird.DoSound();
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            TryDifferentPersons();
            CreateVariousAnimals();
            CreateVariousBirds();
        }
    }
}
