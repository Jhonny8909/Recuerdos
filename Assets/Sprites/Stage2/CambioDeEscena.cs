using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int nombreNivel = 5;
        SceneManager.LoadScene(nombreNivel);

    }
}
