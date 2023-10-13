using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void AddItem(string name, int power)
    {
        Item newItem = new Item(name, power);
        items.Add(newItem);
    }

    public List<Item> GetItems()
    {
        return items;
    }
}
