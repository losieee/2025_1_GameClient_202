using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Inventory/Database")]
public class ItemDatabaseSO : ScriptableObject
{
    public List<ItemSO> items = new List<ItemSO>();

    private Dictionary<int, ItemSO> itemById;
    private Dictionary<string, ItemSO> itemsByName;

    public void initialize()
    {
        itemById = new Dictionary<int, ItemSO>();
        itemsByName = new Dictionary<string, ItemSO>();

        foreach (var item in items)
        {
            itemById[item.id] = item;
            itemsByName[item.itemName] = item;
        }
    }

    public ItemSO GetItemById(int id)
    {
        if (itemById == null)

        {
            initialize();
        }
        if (itemById.TryGetValue(id, out ItemSO item))
            return item;
        return null;
    }

    public ItemSO GetItemById(string id)
    {
        if (itemsByName == null)
        {
            initialize();
        }
        if (itemsByName.TryGetValue(name, out ItemSO item))
            return item;

        return null;
    }

    public List<ItemSO> GetItemByType(ItemType type)
    {
        return items.FindAll(item => item.itemType == type);
    }
}
