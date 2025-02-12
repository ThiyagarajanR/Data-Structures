using System;

public class BookPriceAverage
{
    public static void Main(string[] args)
    {
        int size;
        GetSize(out size);
        decimal[] bookPrices = new decimal[size]; // Use decimal array

        decimal averageBookPrice = 0.0m;

        GetElements(bookPrices, size);

        GetAveragePrice(bookPrices, size, out averageBookPrice);

        Console.WriteLine($"The average price of the books is {averageBookPrice}");
    }

    void GetSize(out int size)
    {
        Console.WriteLine("Enter the size of the array:");
        size = int.Parse(Console.ReadLine()); // Correct: Array size must be an integer
    }

    void GetElements(decimal[] bookPrices, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter the price of book number {i + 1}:");
            bookPrices[i] = decimal.Parse(Console.ReadLine()); // Correct: Prices can be decimals
        }
    }

    void GetAveragePrice(decimal[] bookPrices, int size, out decimal averageBookPrice)
    {
        decimal decimalSum = 0.0m;
        foreach (decimal price in bookPrices)
        {
            decimalSum += price;
        }

        averageBookPrice = decimalSum / size;
    }
}