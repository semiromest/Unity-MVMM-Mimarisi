using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Collections.Generic;
using TMPro;

public class ItemView : MonoBehaviour
{
    public ItemController itemController;
    public TMP_InputField itemNameInputField;
    public TMP_InputField itemPowerInputField;
    public TextMeshProUGUI itemListViewText;
    public Button addItemButton;

    private void Start()
    {
        UpdateItemList();
        addItemButton.onClick.AddListener(AddNewItem);
    }

    public void AddNewItem()
    {
        string name = itemNameInputField.text;
        int power = int.Parse(itemPowerInputField.text);

        itemController.AddItem(name, power);
        UpdateItemList();
    }

    public void UpdateItemList()
    {
        List<Item> items = itemController.GetItems();
        StringBuilder itemListText = new StringBuilder("Items:\n");

        foreach (Item item in items)
        {
            itemListText.AppendLine(item.Name + " (Power: " + item.Power + ")");
        }

        itemListViewText.text = itemListText.ToString();
    }
}
