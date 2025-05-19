
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public float spawnCycle = 0.5f;

    private GameManager manager;
    private float elapsedTime;
    private bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            if (spawnPowerup)
                temp = Instantiate(powerupPrefab);
            else
                temp = Instantiate(obstaclePrefab);

            // Randomize X position
            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            // Assign GameManager reference
            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            // Reset timer and toggle object type
            elapsedTime = 0f;
            spawnPowerup = !spawnPowerup;
        }
    }
}
