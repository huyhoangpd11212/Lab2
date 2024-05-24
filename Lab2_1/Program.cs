using System;

public class UserData
{
    public int id;
    public string username;
    public int level;

    public UserData(int id, string username, int level)
    {
        this.id = id;
        this.username = username;
        this.level = level;
    }

    public void ShowData()
    {
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"UserName: {username}");
        Console.WriteLine($"Level: {level}");
    }

    public void ShowData(string name, dynamic attribute)
    {
        Console.WriteLine($"{name}: {attribute}");
    }
}

public class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine("Bài 1a");
        var x = 10;
        void bai1a()
        {
            Console.WriteLine($"x: {x}");
        }
        bai1a();
        Console.WriteLine();

        Console.WriteLine("Bài 1b");
        void getDetail(dynamic value)
        {
            Console.WriteLine($"Value: {value}");
        }
        void bai1b()
        {
            getDetail(10);
            getDetail("games");
            getDetail(true);
            getDetail(9.5f);
        }
        bai1b();
        Console.WriteLine();

        Console.WriteLine("Bài 1c");
        UserData userData = new UserData(0, "First Player", 0);
        userData.ShowData("Level", userData.level);
        userData.ShowData("Id", userData.id);
        userData.ShowData("UserName", userData.username);
        Console.WriteLine();

        return 0;
    }
}
