using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

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
            inputVector += Vector2.left; // Left: (-1,0)
        }

        OnMove?.Invoke(inputVector);
    }
}
