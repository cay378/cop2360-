// Making a class utilizing fields, constructors, and methods.
public class Octopus
{
    public string Name { get; }
    public string Color { get; }
    public int Legs { get; } = 10; 

    // Setting up the constructor
    public Octopus(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Setting up the method to display the information
    public void DisplayInfo()
    {
        Console.WriteLine($"Our octopus, {Name}, is a cool shade of {Color} and has {Legs}.");
    }
}

// Main Program to create the Opctopus instance 
class Program
{
    static void Main()
    {
        // Making an instant of the class
        Octopus octopus = new Octopus("Octivo", "Green");
        // Displaying the final information
        octopus.DisplayInfo();
    }
}