using System;

public abstract class Dish
{
    public string Name { get; set; }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}...");
    }

    public  void Serve()
    {
        Console.WriteLine($"Serving {Name}...");
    }

    public abstract void Taste();
}



public class MainCourse : Dish
{
    public override void Prepare()
    {
        Console.WriteLine($"Cooking the main course: {Name}...");
    }

    public new void Serve()
    {
        Console.WriteLine($"Serving the main course: {Name}...");
    }

    public override void Taste()
    {
        Console.WriteLine($"Tasting the main course: {Name} - Delicious!");
    }
}



public class Dessert : Dish
{
    public override void Prepare()
    {
        Console.WriteLine($"Preparing the dessert: {Name}...");
    }

    public override void Taste()
    {
        Console.WriteLine($"Tasting the dessert: {Name} - Sweet and Yummy!");
    }
}



public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Our Restaurant!");

        MainCourse dish1 = new MainCourse { Name = "Grilled Salmon" };
        Dish dish2 = new Dessert { Name = "Chocolate Cake" };

        #region Notes
        //When you create a instance of MainCourse of type Dish then the method in the MainCourse will be called
        //proviede if they are overridden. If not overridden it will be hidede by the paretn class method and parent 
        //parnet class method will be executed.
        #endregion

        Console.WriteLine("\nHere are our dishes:");

        dish1.Prepare();
        dish1.Serve();
        dish1.Taste();

        Console.WriteLine();

        dish2.Prepare();
        dish2.Serve();
        dish2.Taste();

        Console.WriteLine("\nEnjoy your meal at Our Restaurant!");
    }
}
