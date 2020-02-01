using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInform : MonoBehaviour
{
    public int itemtype;
    public string needName="";
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Epressed, action);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Epressed, action);
    }
    void action(string name)
    {
        if (gameObject.name == name)
        {
            if (itemtype == 0)
            {
                if (needName == "")
                {
                    Debug.Log(gameObject.name);
                    Debug.Log(GetComponent<SpriteRenderer>().sprite);
                    Messenger.Broadcast<string, Sprite>(Events.itemget, gameObject.name, GetComponent<SpriteRenderer>().sprite);
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}