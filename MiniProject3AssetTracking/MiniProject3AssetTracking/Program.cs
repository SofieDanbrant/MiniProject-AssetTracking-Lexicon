using System;
using System.Globalization;
using System.Collections.Generic;
using MiniProject3AssetTracking;
using System.Linq;
// See https://aka.ms/new-console-template for more information

List<Asset> assets = new List<Asset>();


Console.WriteLine("Welcome to the Asset Tracking System! \n to exit type 'q'");
while (true)
{
    Console.Write("input type. 1 for computer, 2 for mobile: ");
    string typeInput = Console.ReadLine();
    if (typeInput == "q")
    {
        break;
    }

    string type = typeInput == "1" ? "Computer" : typeInput == "2" ? "Mobile": null;
    if (type == null)
    {
        Console.WriteLine("Invalid input, please try again.");
        continue;
    }

    Console.Write("Enter brand: ");
    string brand = Console.ReadLine();
    Console.Write("Enter model: ");
    string model = Console.ReadLine();
    Console.Write("Enter price: ");
    double price = float.Parse(Console.ReadLine());
    Console.Write("Enter purchase date (yyyy-MM-dd): ");
    string purchaseDateInput = Console.ReadLine();
    DateOnly purchaseDate = DateOnly.ParseExact(purchaseDateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture);


    if (type == "Computer")
    {
        assets.Add(new Computer(brand, model, price, purchaseDate));
    }
    else if (type == "Mobile")
    {
        assets.Add(new Mobile(brand, model, price, purchaseDate));
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The asset has been added successfully!");
    Console.ResetColor();

    Console.WriteLine("-----------------------------------------------");
}

var sortedAssets = assets.OrderBy(a => a.Type).ThenBy(a => a.PurcaseDate).ToList();

if (assets.Any())
{
    Console.WriteLine("\nAll Assets:");
    Console.WriteLine("Type      | Brand      | Model      | Price    | Purchase Date");
    Console.WriteLine("---------------------------------------------------------------");

    var table = sortedAssets.Select(a => $"{a.Type,-10} | {a.Brand,-10} | {a.Model,-10} | {a.Price,8:F2} | {a.PurcaseDate:yyyy-MM-dd}");

    foreach (var row in table)
    {
        Console.WriteLine(row);
    }
}
else
{
    Console.WriteLine("No assets to display.");
}