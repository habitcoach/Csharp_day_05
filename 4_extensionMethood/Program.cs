public class FoodItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public void Display()
    {
        Console.WriteLine($"Item: {Name}, Price: ${Price}");
    }
}



public static class FoodItemExtensions
{
    public static void ApplyDiscount(this FoodItem foodItem, double discountPercentage)
    {
        foodItem.Price = foodItem.Price - (foodItem.Price * discountPercentage / 100);
        Console.WriteLine($"Discounted Price for {foodItem.Name}: ${foodItem.Price}");
    }
}


class Program
{
    static void Main()
    {
        FoodItem burger = new FoodItem
        {
            Name = "Deluxe Burger",
            Price = 100
        };

        burger.Display(); 

        // Using the extension method to apply a 10% discount to the burger!
        burger.ApplyDiscount(10); // Output: Discounted Price for Deluxe Burger: $8.99

       
        burger.Display(); 
    }
}
