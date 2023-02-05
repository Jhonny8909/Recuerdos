using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Regreoshub : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int nombreNivel=4;
        SceneManager.LoadScene(nombreNivel);
        
    }
}
