using System;

[Serializable]
public class Item
{
    public string Name;
    public int Power;

    public Item(string name, int power)
    {
        Name = name;
        Power = power;
    }
}
