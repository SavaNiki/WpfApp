using System;
using System.Collections.Generic;

public class User
{
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Group { get; set; }
    public DateTime LastLoginDate { get; set; }
    public DateTime AccountCreationDate { get; set; }
    public int WarningCount { get; set; }

    public User(string fullName, string username, string password, string group, DateTime lastLoginDate, DateTime accountCreationDate, int warningCount)
    {
        FullName = fullName;
        Username = username;
        Password = password;
        Group = group;
        LastLoginDate = lastLoginDate;
        AccountCreationDate = accountCreationDate;
        WarningCount = warningCount;
    }

    public void UpdateWarningCount(int count)
    {
        WarningCount += count;
    }
}

public class UserList
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void RemoveUser(User user)
    {
        users.Remove(user);
    }
}

class Program
{
    static void Main()
    {
        User user1 = new User("Иванов Иван Иванович", "ivan123", "qwerty", "Admin", DateTime.Now, DateTime.Now, 0);
        User user2 = new User("Петров Петр Петрович", "petr456", "1234", "User", DateTime.Now, DateTime.Now, 0);

        UserList userList = new UserList();
        userList.AddUser(user1);
        userList.AddUser(user2);

        foreach (User user in userList)
        {
            Console.WriteLine($"Пользователь: {user.FullName}, Логин: {user.Username}, Группа: {user.Group}");
        }
    }
}
