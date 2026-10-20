using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Animal
{
    public string breed, name;
    public int age, weight;
    public float height;

    public Animal()
    {
        breed = "";
        name = "";
        age = -1;
        weight = -1;
        height = -1.0f;
    }

    public void Display()
    {
        Console.WriteLine("Breed: " + breed);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Height: " + height);
    }
}

class Program
{
    static int Main()
    {
        // creating an object
        Animal dog = new Animal();

        dog.breed = "French Bulldog";
        dog.name = "Peanut";
        dog.age = 4;
        dog.weight = 17;
        dog.height = 30.1f;

        dog.Display();

        return 0;
    }
}

