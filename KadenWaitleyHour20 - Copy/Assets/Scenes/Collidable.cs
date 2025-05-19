using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Update()
    {
        // Move the object toward the player
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Adjust game time (positive or negative)
            manager.AdjustTime(timeAmount);

            // Destroy the object
            Destroy(gameObject);
        }
    }
}
