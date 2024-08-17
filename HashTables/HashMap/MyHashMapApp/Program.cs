using System;

public class MyHashMap
{

    private int[] map;

    public MyHashMap()
    {
        map = new int[1000001];
        Array.Fill(map, -1);
    }

    public void Put(int key, int value)
    {
        map[key] = value;
    }

    public int Get(int key)
    {
        return map[key];
    }

    public void Remove(int key)
    {
        map[key] = -1;
    }
}

public class PhoneBook
{
    private Dictionary<string, string> phoneBook;

    public PhoneBook()
    {
        int n = int.Parse(Console.ReadLine());
        phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().Split(' ');
            string name = entry[0];
            string phoneNumber = entry[1];
            phoneBook[name] = phoneNumber;
        }
    }

    public void Query()
    {
        string query;
        while ((query = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(query))
            {
                Console.WriteLine($"{query}={phoneBook[query]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1);
        myHashMap.Put(2, 2);
        Console.WriteLine(myHashMap.Get(1));
        Console.WriteLine(myHashMap.Get(3));
        myHashMap.Put(2, 1);
        Console.WriteLine(myHashMap.Get(2));
        myHashMap.Remove(2);
        Console.WriteLine(myHashMap.Get(2));

        //returns: 1 -1 1 -1

        // PhoneBook 
        Console.WriteLine("Enter phone book entries:");
        PhoneBook myPhoneBook = new PhoneBook();
        Console.WriteLine("Query phone book:");
        myPhoneBook.Query();
    }
}
