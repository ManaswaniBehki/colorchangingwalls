// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class camerafollower : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Transform target;
//     private Vector3 offset;

//     private void Start()
//     {
//         offset = transform.position - target.position;

//     }

//     private void Update()
//     {
//         transform.position = new Vector3(target.position.x + offset.x, target.position.y+offset.y,target.position.z+offset.z);
        
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f; // Adjust this value to control the camera follow speed
    public float rotationSpeed = 2f; // Adjust this value to control the camera rotation speed

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        // Camera follow
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Camera rotation with cursor input
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.y += mouseX * rotationSpeed;
        transform.eulerAngles = currentRotation;
    }
}
