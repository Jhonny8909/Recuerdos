using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Dialogo : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;
    private float typingTime = 0.05f;

    [SerializeField] private float tiempoEntreStop;
    [SerializeField] private float tiempoSigStop;

    [SerializeField] private float tiempoEntreStop2;
    [SerializeField] private float tiempoSigStop2;

    public AudioSource cancion;

    private int contador;

    void FixedUpdate()
    {

        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
                cancion.Play();
                tiempoSigStop2 = tiempoEntreStop2;
                tiempoSigStop = tiempoEntreStop;
            }
        }
        if (tiempoSigStop > 0)
        {
            tiempoSigStop -= Time.deltaTime;
        }
        if (tiempoSigStop <= 0)
        {

            
            NextDialogueLine();
        }

        if (tiempoSigStop2 > 0)
        {
            tiempoSigStop2 -= Time.deltaTime;
        }
        if (tiempoSigStop2 <= 0)
        {

            tiempoSigStop2 = tiempoEntreStop2;
            NextDialogueLine();
            contador++;
        }
        if(contador == 9)
        {
            StopAllCoroutines();
            dialogueText.text = dialogueLines[lineIndex];
        }
    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        lineIndex = 0;
        StartCoroutine(ShowLine());
       // Time.timeScale = 0f;
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
           // Time.timeScale = 1f;
        }
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;
        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Dialogo");
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("NO Dialogo");
        }

    }
}
