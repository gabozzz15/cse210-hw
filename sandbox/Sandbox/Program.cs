using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        /*Person persona1 = new Person();
        persona1._firstName = "Allison";
        persona1._lastName = "Rose";
        persona1.age = 21;

        Person persona2 = new Person();
        persona2._firstName = "John";
        persona2._lastName = "Doe";
        persona2.age = 30;

        Person persona3 = new Person();
        persona3._firstName = "Jane";
        persona3._lastName = "Smith";
        persona3.age = 25;

        List<Person> people = new List<Person>();
        people.Add(persona1);
        people.Add(persona2);
        people.Add(persona3);

        foreach (Person persona in people)
        {
            Console.WriteLine(persona._firstName);
        }

        SaveToFile(people);*/
        List<Person> newPeople = ReadFromFile();
        foreach (Person persona in newPeople)
        {
            Console.WriteLine($"{persona._firstName} {persona._lastName} {persona.age}");
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person persona in people)
            {
                outputFile.WriteLine($"{persona._firstName},{persona._lastName},{persona.age}");
            }
        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            // line will have something like: Allison,Rose,21
            string[] parts = line.Split(",");

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson.age = int.Parse(parts[2]);
            people.Add(newPerson);
        }

        return people;
    }


}