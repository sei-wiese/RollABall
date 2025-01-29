using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // initialize the input vector - (0,0)
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // Up: (0,1)
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down; // Down: (0,-1)
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right; // Right: (1,0)
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left; // Down: (-1,0)
        }
        
        Debug.Log("Resultant Vector: " + inputVector);
    }
}
