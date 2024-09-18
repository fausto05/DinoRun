using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float upForce = 0;
    private Rigidbody2D dinoRb;
    private bool tocandoPiso = true;
    void Start()
    {
        dinoRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocandoPiso)
        {
            dinoRb.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
            tocandoPiso = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tocandoPiso = true;
    }
}
