using System;


public class MenuItemNotFoundException : Exception
{


    public MenuItemNotFoundException(string message) : base(message)
    {

    }
}

public class RestaurantMenu
{
    
    private static string[] menuItems = { "Burger", "Pizza", "Pasta", "Salad" };

    public static void OrderMenuItem(string item)
    {
        if (Array.Exists(menuItems, x => x.Equals(item, StringComparison.OrdinalIgnoreCase)))
        {
            
            Console.WriteLine($"You have ordered {item}.");
        }
        else
        {
            throw new MenuItemNotFoundException($"Sorry, {item} is not available in the menu.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Restaurant!");

        try
        {
            
            RestaurantMenu.OrderMenuItem("Burger");
            RestaurantMenu.OrderMenuItem("Pizza");
            RestaurantMenu.OrderMenuItem("Ice Cream"); // This item is not in the menu
            RestaurantMenu.OrderMenuItem("Salad");

            // Uncomment the next line to test the custom exception for ordering an unavailable item
            // RestaurantMenu.OrderMenuItem("Sushi");
        }
        catch (MenuItemNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Thank you for visiting the Restaurant!");
    }
}
