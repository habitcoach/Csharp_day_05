using System;


public class Shape
{

    protected string name;

    
    public Shape(string shapeName)
    {
        name = shapeName;
    }

  
    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a shape called: " + name);
    }
}



public abstract class TwoDimensionalShape : Shape
{

    public TwoDimensionalShape(string shapeName) : base(shapeName)
    {
    }


    public abstract double GetArea();


    
   
}


public sealed class Circle : TwoDimensionalShape
{
    private double radius;

    

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;

    }

   

    public override double GetArea()
    {
        return Math.PI * radius * radius;
       
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle("Circle 1", 5.0);
        circle.DisplayInfo();
        Console.WriteLine("Area: " + circle.GetArea());

       

       
       
        // class Square : Circle { }
    }
}
