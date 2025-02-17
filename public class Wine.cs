public class Wine
{
  public decimal Price;
  public int Year;
  public Wine (decimal price) => Price = price;
  public Wine (decimal price, int year) : this (price) => Year = year;
}

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"This wine is from {year} and cost ${price})
}


// Main Program to create an instance of Octopus
class Program
{
    static void Main()
    {
        // Object initialization
        Wine w = new Wine(78, 1957);
        w.DisplayInfo();
    }
}