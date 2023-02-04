using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubiculo : MonoBehaviour
{
    private Contador contador;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (contador.contador > 0)
        {
            if (collision.CompareTag("Player")) { 
            
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        

    }
}
