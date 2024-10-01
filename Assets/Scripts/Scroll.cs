using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSuelo : MonoBehaviour
{
    private float scrollSpeed = 8f;

    private void Update()
    {
        transform.Translate(Vector2.left *  scrollSpeed * Time.deltaTime);
    }
}
