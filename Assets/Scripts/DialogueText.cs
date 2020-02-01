using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueText : MonoBehaviour
{
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Interact, PrintText);

    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Interact, PrintText);

    }

    void PrintText(string name)
    {
        GetComponentInChildren<TextMesh>().text = name;

    }
}
