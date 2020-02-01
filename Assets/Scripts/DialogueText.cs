using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
        gameObject.transform.localScale = Vector3.one;
        GetComponentInChildren<TextMeshProUGUI>().text = name;

    }

}
