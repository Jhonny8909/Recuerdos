using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    private int contador;
    private bool isPlayerInRange;
    public GameObject Objetivo;

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            contador++;
            Debug.Log(contador);
            if (contador == 2)
            {
                Objetivo.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Objeto"))
        {
            isPlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Objeto"))
        {
            isPlayerInRange = false;
        }
    }
}
