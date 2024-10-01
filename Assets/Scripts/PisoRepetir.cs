using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoRepetir : MonoBehaviour
{
    private float anchoDeSprite;
    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        anchoDeSprite = groundCollider.size.x;
    }

    void Update()
    {
        if (transform.position.x < -anchoDeSprite)
        {
            transform.Translate(Vector2.right * 2f * anchoDeSprite);
        }
    }
}
