using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    [SerializeField] public int contador;
    [SerializeField] public int limite;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (limite <= contador)
        {
            if (collision.CompareTag("Objeto"))
            {
                contador++;
                Debug.Log(contador);
            }
            else if (collision.CompareTag("Objetivo"))
            {
                contador--;
                Debug.Log(contador);
            }
        }
        
        
    }

}
