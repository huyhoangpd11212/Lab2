using System;

class Program
{
    static void Main(string[] args)
    {
        // Bai 2a
        Console.WriteLine("Bai 2a:");
        Console.WriteLine();
        var userInfo = new
        {
            id = "2023",
            name = "Faker",
            isDisplay = false,
            bag = new
            {
                skins = 0,
                cups = 0,
            }
        };
        Console.WriteLine($"Id: {userInfo.id}");
        Console.WriteLine($"Name: {userInfo.name}");
        Console.WriteLine($"Is Display: {userInfo.isDisplay}");
        Console.WriteLine($"Bag Skins: {userInfo.bag.skins}");
        Console.WriteLine();

        Console.WriteLine("--------------------------");
        Console.WriteLine();

        // Bai 2b
        Console.WriteLine("Bai 2b:");
        Console.WriteLine();
        int y = 10;
        Action<dynamic> AnonymousMethod = delegate (dynamic x)
        {
            int sum = x + y;
            int sub = x - y;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Sub = {sub}");
        };
        AnonymousMethod(5);
    }
}
