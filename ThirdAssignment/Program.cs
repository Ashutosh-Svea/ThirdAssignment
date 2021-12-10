using System;
using System.Collections.Generic;

namespace ThirdAssignment
{
    class Program
    {

        static void FindTheDogsAndPrintOptionalFunction(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                if (animal is Dog)
                //if (animal.GetType() == typeof(Dog))
                {
                    Console.WriteLine("calling optional method for dog now");
                    //maybe change it to temp object and use as operator instead of explicit cast which can through exception...?
                    Console.WriteLine(((Dog)animal).Optional());
                }
            }
        }

        static void AllAnimalStats(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();

                //check if animal is also derived from interface IPerson
                //if (animal.GetType().GetInterface("IPerson") != null)
                if (animal is IPerson)
                {
                    Console.WriteLine($"Animal {animal.Stats()} is also a Person.");
                    ((IPerson)animal).Talk();
                }

            }
        }
        static List<Dog> CreateDogList()
        {
            List<Dog> dogList = new List<Dog>();
            dogList.Add(new Dog("Dog1", 1.4, 4, "German shepherd"));
            dogList.Add(new Dog("Dog2", 2.4, 2, "Greyhound"));
            dogList.Add(new Dog("Dog3", 3.4, 1, "Golden Retriever"));
            dogList.Add(new Dog("Dog4", 0.4, 6, "Dobermann"));

            //Horse horse = new Horse("horse1", 55, 12, 49);
            //dogList.Add(horse);

            //Error one gets is: Cannot convert Horse to Dog.
            

            return dogList;
        }

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

        static List<Animal> CreateVariousAnimals()
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
            return animalList;
        }

        static List<Bird> CreateVariousBirds()
        {
            Bird flamingo = new Flamingo("flamingo1", 1.5, 1, 3, 2);
            Bird pelican = new Pelican("pelican1", 15, 2, 5, Utils.BirdColor.Blue);
            Bird swan = new Swan("swan1", 3, 5, 6, 2.2);

            List<Bird> birdList = new List<Bird>();
            birdList.Add(flamingo);
            birdList.Add(pelican);
            birdList.Add(swan);
            return birdList;
        }

        static void TryAnimals()
        {
            try
            {

                List<Animal> animalList = CreateVariousAnimals();   //create various derived class animal instances and return as List
                List<Bird> birdList = CreateVariousBirds();         //create various birds and return list of birds
                List<Dog> dogList = CreateDogList();                //create various dogs and try the adding horse to dog list case.

                animalList.AddRange(birdList);

                animalList.AddRange(dogList);

                Wolfman wolfman = new Wolfman("wolfman1", 89, 44, 55);

                animalList.Add(wolfman);

                AllAnimalStats(animalList);                         //print all stats for all animals.

                FindTheDogsAndPrintOptionalFunction(animalList);    //loop thorugh animal list, find the dogs and print the optional function
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void TryErrors()
        {
            List<UserError> errorList = new List<UserError>();
            errorList.Add(new NumericInputError());
            errorList.Add(new TextInputError());

//three more error classes. have just been printing the error message in loop. perhaps later use in animal classes and person class.
            errorList.Add(new ObjectInputError());
            errorList.Add(new OperatorInputError());
            errorList.Add(new UnknownInputError());

            foreach (UserError er in errorList)
            {
                Console.WriteLine(er.UEMessage());
            }
        }
        static void Main(string[] args)
        {
            TryDifferentPersons(); //add various persons with PersonHandler and test various cases. Part 1 of assignment...

            TryAnimals();

            TryErrors();

            //Let the GC clean it all...not deleting anything manually.
        }
    }
}
