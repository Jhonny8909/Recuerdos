using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Regreoshub : MonoBehaviour
{
    public int nombreNivel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        SceneManager.LoadScene(nombreNivel);
        
    }
}
