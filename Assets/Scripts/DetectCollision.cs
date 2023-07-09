using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.state = GameState.LOST;
            Destroy(collision.gameObject);
            gameManager.ShowMenu();
        }
    }
}
