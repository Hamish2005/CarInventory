namespace SE2250_Lab2;

class Program
{
    //Adding Comment 
    static void Main()
    {
        Car myCar = new Car();

        Console.Write("Enter car brand: ");
        myCar.Brand = Console.ReadLine();

        Console.Write("Enter car year: ");
        myCar.Year = int.Parse(Console.ReadLine());
         

        Console.Write("Enter car price: ");
        myCar.Price = double.Parse(Console.ReadLine());

        Console.WriteLine("\nCar Details:");
        Console.WriteLine($"Brand: {myCar.Brand}");
        Console.WriteLine($"Year: {myCar.Year}");
        Console.WriteLine($"Price: ${myCar.Price}");
    }
}