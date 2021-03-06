using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportUtils : MonoBehaviour
{


    public float x;
    public float y;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(x, y);
        }
    }

}
