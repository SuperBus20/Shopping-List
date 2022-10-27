Dictionary<string, double> storeItems = new Dictionary<string, double>()
{
    {"9 eggs", 7.82 },
    {"gallon of milk", 4.20 },
    {"shopping cart", 128.99 },
    {"stuffed eggplant emoji", 7.63 },
    {"blockbuster coupon", 0.99 },
    {"the planet mars", 12000000000000.43 },
    {"two pennies", 0.01 },
    {"1 hour with a screaming toddler", 8.30 }
};
List<string> itemsInCart = new List<string>();
List<double> costOfItems = new List<double>();
//double sumCost = 0;

Console.WriteLine("here is a list of things we sell with their price attached");
Console.WriteLine();

foreach (var item in storeItems)
{
    Console.WriteLine(item);
}
bool anotherItem = true;
Console.WriteLine();


while (anotherItem)
{
    Console.WriteLine("what would you like to buy today ?");

    string itemChoice = Console.ReadLine();
    while (!storeItems.ContainsKey(itemChoice))
    {
        Console.WriteLine("that is not an item sorry");
        Console.WriteLine("Please choose another item.");
        itemChoice = Console.ReadLine();
    }
    
    itemsInCart.Add(itemChoice);
    

    

    Console.WriteLine("would you like to add another item to your shopping list? (y/n)");
    string goAgain = Console.ReadLine();
    if (goAgain != "y")
    {
        anotherItem = false;
    }
}

foreach (string item in itemsInCart)
{

    /*sumCost*/ costOfItems.Add (storeItems.GetValueOrDefault(item));
}
Console.WriteLine("your items are as follows");
foreach (string item in itemsInCart)
{
   Console.WriteLine ($"{item},");

}
Console.WriteLine("with their respective costs being");
foreach (double cost in costOfItems)
{
    Console.WriteLine($"{cost:C}");

}
Console.WriteLine($"for a total of {costOfItems.Sum():C}");
Console.ReadKey();

