using UnityEngine;

public class BallController : MonoBehaviour
{
    // public Rigidbody sphereRigidbody;
    // public float ballSpeed = 2f;    //  Variables to control the ball speed

    // [SerializeField] private Rigidbody sphereRigidbody;
    // [SerializeField] private float ballSpeed = 2f;

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }


    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     Debug.Log("Calling the Start method");  // variable to get Rigidbody
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     Vector2 inputVector = Vector2.zero; // initialize the input vector - (0,0)
    //     if (Input.GetKey(KeyCode.W))
    //     {
    //         inputVector += Vector2.up; // Up: (0,1)
    //     }
    //     if (Input.GetKey(KeyCode.S))
    //     {
    //         inputVector += Vector2.down; // Down: (0,-1)
    //     }
    //     if (Input.GetKey(KeyCode.D))
    //     {
    //         inputVector += Vector2.right; // Right: (1,0)
    //     }
    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         inputVector += Vector2.left; // Down: (-1,0)
    //     }

    //     Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);  // Convert 2D vector (XY) to 3D vector (XZ)
    //     // Debug.Log("Resultant Vector: " + inputVector);
    //     // Debug.Log("Resultant 3D Vector: " + inputXZPlane);
        
    //     // sphereRigidbody.AddForce(inputXZPlane);
    //     sphereRigidbody.AddForce(inputXZPlane * ballSpeed);   // Move the ball in accordance with ballSpeed.
    // }
}
