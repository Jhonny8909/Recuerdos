using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class notamov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Rigidbody2D _rb;
    private Vector2 moveVector;
    public float moveSpeed;

    private void Awake()
    {
        //Cuando inicie la escena el script mandara a llamar al rb y a la gravedad del rb y se definiran en las variables
        _rb = GetComponent<Rigidbody2D>();
    }  

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(-1 * moveSpeed, _rb.velocity.y);
        _rb.velocity = new Vector2(_rb.velocity.x, moveVector.y * moveSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        int nombreNivel = 6;
        SceneManager.LoadScene(nombreNivel);
    }
}
