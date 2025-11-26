using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : MonoBehaviour
{
    private Vector3 _currentPosition;
    private float _walkSpeed = 2f;
    private float _runSpeed = 4f;
    private float _maxStamina = 100f;
    private float _currentStamina = 100f;
    private float _staminaLoss = 0.5f;
    
    public InputAction MoveAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = _walkSpeed;
        bool running = false;
        if (Keyboard.current.shiftKey.isPressed && _currentStamina > 0)
        {
            moveSpeed = _runSpeed;
            running = true;
        }
        
        Vector2 move = MoveAction.ReadValue<Vector2>();
        _currentPosition = (Vector2)transform.position + move * moveSpeed * Time.deltaTime;
        
        if(running)
            _currentStamina -= _staminaLoss;
       
        
        transform.position = _currentPosition;
        UIManager.Instance.SetStaminaBar(_currentStamina);  
    }
}
