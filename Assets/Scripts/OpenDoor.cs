using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject canvas;

    private void Awake()
    {
        canvas.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            canvas.SetActive(true);
        }

    }

}

