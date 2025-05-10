namespace Lab8;

class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("The animal makes a sound.");
    
    }
}

class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The cat says meow.");
    }
}

class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says bow wow.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal MyAnimal = new Animal();
        Animal MyCat = new Cat();
        Animal MyDog = new Dog();

        MyAnimal.AnimalSound();
        MyDog.AnimalSound();
        MyCat.AnimalSound();

    }
}
