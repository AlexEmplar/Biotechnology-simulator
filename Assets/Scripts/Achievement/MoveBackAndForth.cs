using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float distance = 1f;

    private float timer;
    private bool isMovingRight;
    private float targetX;
    private void Start()
    {
        // Start the first move-right cycle
        isMovingRight = true;
        timer = 0;
        float targetX = transform.position.x;
    }

    private void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Calculate the target position based on the current phase
        if (isMovingRight)
        {
            // Move-right phase
            if (timer > distance / speed)
            {
                // Switch to the move-left phase
                isMovingRight = false;
                timer = 0;
            }
            else
            {
                // Calculate the target X position
                targetX = transform.position.x + speed * Time.deltaTime;
            }
        }
        else
        {
            // Move-left phase
            if (timer > distance / speed)
            {
                // Switch to the move-right phase
                isMovingRight = true;
                timer = 0;
            }
            else
            {
                // Calculate the target X position
                targetX = transform.position.x - speed * Time.deltaTime;
            }
        }

        // Update the position of the game object
        Vector3 newPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
