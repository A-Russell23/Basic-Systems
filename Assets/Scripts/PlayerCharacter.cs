using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    private Vector3 _currentPosition;
    private float _walkSpeed = 2f;
    private float _runSpeed = 4f;
    
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
            _currentPosition.y += moveSpeed * Time.deltaTime;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            _currentPosition.y -= moveSpeed * Time.deltaTime;
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            _currentPosition.x -= moveSpeed * Time.deltaTime;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            _currentPosition.x += moveSpeed * Time.deltaTime;
        }
        
        transform.position = _currentPosition;
    }
}
