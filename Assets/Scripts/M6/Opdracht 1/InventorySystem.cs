using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    private int numGuns = 0;
    private List<InventoryItem> _itemsInWorld = new List<InventoryItem>();
    private List<InventoryItem> _itemsInInventory = new List<InventoryItem>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _itemsInWorld.Add(new GunItem());
        _itemsInWorld[0].Identify();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) 
        {
            foreach (InventoryItem item in _itemsInWorld) 
            {
                if (item is GunItem)
                {
                    _itemsInInventory.Add(item);
                    _itemsInWorld.Remove(item);
                    break;
                }
            }
            
            foreach (InventoryItem item in _itemsInInventory) { 
                if(item is GunItem)numGuns++;
            }
            Debug.Log("Inventory: Guns:" + numGuns);

        }

      

    }
    
}
