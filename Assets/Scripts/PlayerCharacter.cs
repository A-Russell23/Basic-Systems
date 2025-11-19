using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    private Vector3 _currentPosition;
    private float _walkSpeed = 0.025f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            _currentPosition.y += _walkSpeed;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            _currentPosition.y -= _walkSpeed;
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            _currentPosition.x -= _walkSpeed;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            _currentPosition.x += _walkSpeed;
        }
        
        transform.position = _currentPosition;
    }
}
