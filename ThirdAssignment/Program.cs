using System;

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
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            TryDifferentPersons();
        }
    }
}
