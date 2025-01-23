namespace SE2250_Lab2;

public class Car
{
    private string brand;    
    private int year;
    private double price;
    // Brand
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    // Year
    public int Year
    {
        get { return year; }
        set
        {
            if (value < 2000)
            {
                throw new ArgumentException("Year cannot be earlier than 2000.");
            }
            year = value;
        }
    }

    // Price
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            price = value;
        }
    }
    
}