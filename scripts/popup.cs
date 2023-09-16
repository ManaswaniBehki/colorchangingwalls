using UnityEngine;
using UnityEngine.UI;

public class WallCollisionText : MonoBehaviour
{
    public Text collisionText;
    private bool isColliding = false;

    private void Start()
    {
        // Hide the collision text at the start
        collisionText.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the character collides with a wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Show the collision text
            collisionText.gameObject.SetActive(true);
            isColliding = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the character moves away from the wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Hide the collision text
            collisionText.gameObject.SetActive(false);
            isColliding = false;
        }
    }

    private void Update()
    {
        // You can add additional actions while colliding with the wall here
        if (isColliding)
        {
            // For example, you can make the text follow the player's position
            // collisionText.transform.position = transform.position + new Vector3(0, 2, 0);
        }
    }
}
