using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private bool isPlayerInRange;
    public GameObject Objetivo;
    public bool activado;

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
            Objetivo.SetActive(true);
            activado = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
