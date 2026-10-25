using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Animal
{
    public string name;
    public int age, weight;
    public float height;

    public Animal()
    {
        name = "";
        age = -1;
        weight = -1;
        height = -1.0f;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Height: " + height);
    }
}

class Dog : Animal //inheritance
{
    public string breed; //Specific attribute for dog
    public Dog() //constructor
    {
        breed = "";
    }
    public void AnimalSound() 
    {
        Console.WriteLine("Woof Woof");
    }
    public new void Display()
    {
        base.Display(); //base keyword can use original class' method
        Console.WriteLine("Breed: " + breed);
    }

    public void Trick() //dog specific method
    {
        Console.WriteLine( name + " spins around.");
    }
}

class Program
{
    static int Main()
    {
        // creating an object
        Dog dog = new Dog();

        dog.breed = "French Bulldog";
        dog.name = "Peanut";
        dog.age = 4;
        dog.weight = 17;
        dog.height = 30.1f;

        dog.Display();
        dog.Trick();
        return 0;
    }
}

