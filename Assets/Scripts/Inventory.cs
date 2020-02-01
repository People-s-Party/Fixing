using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Interact, AddInventory);

    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Interact, AddInventory);

    }

    void AddInventory(string name)
    {
        for(int i = 1; i < 8; i++)
        {
            GameObject invTemp = GameObject.Find("Inv" + i);
            //invTemp.AddComponent<SpriteRenderer>().sprite = name;
            

        }

    }
}
