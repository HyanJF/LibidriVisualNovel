using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    public static DialogeManager dialogeManager;
    public TMP_Text dialogueText; 
    public GameObject dialoguePanel;
    private string[] dialogueLines;
    private int currentLine = 0;
    private void Awake()
    {
        if (dialogeManager == null) dialogeManager = this;
        else Destroy(this);
    }
    void Start()
    {
        dialoguePanel.SetActive(false); 
    }

    public void StartDialogue(string[] newDialogues)
    {
        dialogueLines = newDialogues;
        dialoguePanel.SetActive(true);
        ShowNextLine();
    }

    public void ShowNextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        currentLine = 0; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dialoguePanel.activeInHierarchy)
        {
            ShowNextLine();
        }
    }
}
