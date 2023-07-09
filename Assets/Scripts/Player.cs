using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(transform.gameObject);
            gameManager.ShowMenu();
            gameManager.Win();
        }
    }
}
