using UnityEngine;

public class ballcollision : MonoBehaviour
{
    public Material[] wallMaterials; // Array of materials for the walls.
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Get the MeshRenderer component of the wall.
            MeshRenderer wallRenderer = collision.gameObject.GetComponent<MeshRenderer>();

            // Assign a random material from the array to the wall.
            int randomMaterialIndex = Random.Range(0, wallMaterials.Length);
            wallRenderer.material = wallMaterials[randomMaterialIndex];

            // Display a text pop-up indicating the collision.
            
        }
    }
}
