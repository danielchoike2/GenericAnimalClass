using System;
// define a generics class named Animal
public class Animal<T>
{
    // define a field of type T 
    public T data;

    // define a constructor of the Animal class 
    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Animal Data:" + this.data);
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        // create an instance with a string data type
        Animal<string> animalName = new Animal<string>("Boogie");

        // create an instance with another string data type
        Animal<string> animalHabitat = new Animal<string>("Amazon River");

        Animal<bool> endangered = new Animal<bool>(false);

        Animal<bool> extinct = new Animal<bool>(false);

        Animal<int> averageLifespan = new Animal<int>(10);

    } 
}





