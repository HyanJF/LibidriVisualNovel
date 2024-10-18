using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogesScript : MonoBehaviour
{
    public string[] dialoges;

    public void SendDialoges()
    {
        DialogeManager.dialogeManager.StartDialogue(dialoges);
    }
}
