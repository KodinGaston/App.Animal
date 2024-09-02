using System;

public class Animal // parent
{
    public virtual void animalSound()
    {
        Console.WriteLine("Animal sounds");
    }
}
public class Dog : Animal       // child
{
    public override void animalSound()
    {
        Console.WriteLine("The dog barks: WOOF WOOF!");
    }
}
public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat meows: Meow meow.");
    }
}
public class Cow : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cow moos: Moo moo.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal();     // crea un objeto de tipo Animal
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        Animal myCow = new Cow();

        myAnimal.animalSound();     // llama a animalSound
        myDog.animalSound();
        myCat.animalSound();
        myCow.animalSound();
    }
}
