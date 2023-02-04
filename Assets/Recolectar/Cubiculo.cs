using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubiculo : MonoBehaviour
{
    private bool isPlayerInRange;
    private Contador contador;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Accion");
           
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("No accion");
        }

    }
}
