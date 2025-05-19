using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;

    [Header("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phaseCooldown = 2f;

    private Renderer mesh;
    private Collider collision;
    private bool canPhase = true;

    void Start()
    {
        // Try to get the SkinnedMeshRenderer from the children
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();

        // Get the main collider on the player
        collision = GetComponent<Collider>();
    }

    void Update()
    {
        // Handle horizontal movement
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;
        Vector3 position = transform.position;
        position.x += xMove;
        position.x = Mathf.Clamp(position.x, -bounds, bounds);
        transform.position = position;

        // Handle phasing ability
        if (Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;
            mesh.material = phasedMat;
            collision.enabled = false;

            // Call PhaseIn after cooldown
            Invoke("PhaseIn", phaseCooldown);
        }
    }

    void PhaseIn()
    {
        canPhase = true;
        mesh.material = normalMat;
        collision.enabled = true;
    }
}
