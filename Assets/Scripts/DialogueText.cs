using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueText : MonoBehaviour
{
    private void OnEnable()
    {
        Messenger.AddListener(Events.Interactoff, RemoveText);
        Messenger.AddListener<string>(Events.Interact, PrintText);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener(Events.Interactoff, RemoveText);
        Messenger.RemoveListener<string>(Events.Interact, PrintText);
    }

    void PrintText(string name)
    {
        transform.Find("Text").gameObject.SetActive(true);
        transform.Find("Text").GetComponent<TextMeshProUGUI>().text = name;
    }
    void RemoveText()
    {
        transform.Find("Text").gameObject.SetActive(false);
    }

}