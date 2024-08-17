using System;

public class MyHashSet
{
    private bool[] hashSet;

    public MyHashSet()
    {
        hashSet = new bool[1000001];
    }

    public void Add(int key)
    {
        hashSet[key] = true;
    }

    public void Remove(int key)
    {
        hashSet[key] = false;
    }

    public bool Contains(int key)
    {
        return hashSet[key];
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1);
        myHashSet.Add(2);
        Console.WriteLine(myHashSet.Contains(1));
        Console.WriteLine(myHashSet.Contains(3));
        myHashSet.Add(2);
        Console.WriteLine(myHashSet.Contains(2));
        myHashSet.Remove(2);
        Console.WriteLine(myHashSet.Contains(2));

        // returns TRUE FALSE TRUE FALSE.
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);

Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.

Example 1:

Input
["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
[[], [1], [2], [1], [3], [2], [2], [2], [2]]
Output
[null, null, null, true, false, null, true, null, false]

Explanation
MyHashSet myHashSet = new MyHashSet();
myHashSet.add(1);      // set = [1]
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(1); // return True
myHashSet.contains(3); // return False, (not found)
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(2); // return True
myHashSet.remove(2);   // set = [1]
myHashSet.contains(2); // return False, (already removed)

Constraints:

    0 <= key <= 106
    At most 104 calls will be made to add, remove, and contains.

 */