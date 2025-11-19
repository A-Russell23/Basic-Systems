using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    private Vector3 _currentPosition;
    private float _walkSpeed = 0.025f;
    private float _runSpeed = 0.05f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = _walkSpeed;
        if (Keyboard.current.shiftKey.isPressed)
        {
            moveSpeed = _runSpeed;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            _currentPosition.y += moveSpeed;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            _currentPosition.y -= moveSpeed;
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            _currentPosition.x -= moveSpeed;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            _currentPosition.x += moveSpeed;
        }
        
        transform.position = _currentPosition;
    }
}
