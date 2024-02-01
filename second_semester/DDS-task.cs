/*
Да се създаде клас Продукти с подходящи полета. Да се направи метод в него,
който изчислява цената на дребно като към цената на едро добави 18 %.
Да се направи метод, който добавя ДДС (20%) към цената на дребно.
Да се създадат два обекта от този клас и да се отпечатат крайните им цени.
(крайната цена = цена на дребно + ДДС)
*/

using System;

public class Product
{
    private double wholesalePrice;

    public Product(double wholesalePrice)
    {
        this.wholesalePrice = wholesalePrice;
    }

    // Calculate retail price by adding 18% 
    public double CalculateRetailPrice()
    {
        return wholesalePrice * 1.18;
    }

    // Add VAT 20% to retail price
    public double CalculatePriceWithVAT()
    {
        double retailPrice = CalculateRetailPrice();
        return retailPrice * 1.20;
    }
}

public class Program
{
    public static void Main()
    {
        Product product1 = new Product(100); 
        Product product2 = new Product(200); 

        Console.WriteLine($"Product 1 final price (retail price + VAT): {product1.CalculatePriceWithVAT()}");
        Console.WriteLine($"Product 2 final price (retail price + VAT): {product2.CalculatePriceWithVAT()}");
    }
}