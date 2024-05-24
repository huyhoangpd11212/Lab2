using System;
using System.Collections.Generic;

class UserData
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public List<float> Scores { get; set; }

    public UserData(int id, string userName)
    {
        ID = id;
        UserName = userName;
        Scores = new List<float>();
    }
}

class Program
{
    static void Main()
    {
        // Danh sách điểm đã cho trước
        List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

        // Khởi tạo đối tượng UserData với ID và UserName
        UserData user = new UserData(123456, "Nguyen Van A");

        // Nhập điểm từ ldata sang user.Scores
        user.Scores.AddRange(ldata);

        // Hiển thị thông tin người dùng và điểm số
        Console.WriteLine($"ID: {user.ID}");
        Console.WriteLine($"UserName: {user.UserName}");
        Console.WriteLine("Scores: ");
        foreach (var score in user.Scores)
        {
            Console.WriteLine(score);
        }
    }
}
