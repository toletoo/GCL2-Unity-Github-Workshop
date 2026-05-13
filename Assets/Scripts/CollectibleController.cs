using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public int scoreValue = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}