using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject gameObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Win!");
            gameObject.SetActive(true);
        }
    }
}