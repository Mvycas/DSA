using System;

public class MyHashMap {
    
    private int[] map;
    
    public MyHashMap() {
        map = new int[1000001];
        Array.Fill(map, -1);
    }
    
    public void Put(int key, int value) {
        map[key] = value;
    }
    
    public int Get(int key) {
        return map[key];
    }
    
    public void Remove(int key) {
        map[key] = -1;
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
    }
}
