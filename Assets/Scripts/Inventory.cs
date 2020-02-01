using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Transform[] child;
    public Sprite bread;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Messenger.AddListener<string, Sprite>(Events.itemget, AddInventory);

    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string, Sprite>(Events.itemget, AddInventory);

    }

    void AddInventory(string name, Sprite sprite)
    {
        bool isAdded = false;
        Image tempOut;
        for (int i = 1; i < 8; i++)
        {
            GameObject invTemp = GameObject.Find("Inv" + i);
<<<<<<< HEAD
            if (!invTemp.GetComponent<InventoryInform>().hasItem)
            {
                if (!isAdded)
                {
                    if (!invTemp.TryGetComponent<Image>(out tempOut))
                    {
                        invTemp.AddComponent<Image>().sprite = sprite;
                        invTemp.GetComponent<InventoryInform>().hasItem = true;
                        invTemp.GetComponent<InventoryInform>().itemName = name;
                        isAdded = true;

                    }
                    

                }
            }
=======
            GameObject eItem = GameObject.Find(name);
>>>>>>> cbd39af985799a26c00ed54a65fd03ec5736ecc1


        }

    }
}
