using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abuelo : MonoBehaviour
{

    public GameObject controlador;
    public GameObject sprite;
    public GameObject tecla1;
    public GameObject tecla2;
    public GameObject tecla3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controlador.SetActive(true);
        sprite.SetActive(true);
        tecla1.SetActive(true);
        tecla2.SetActive(true);
        tecla3.SetActive(true);

    }
}
