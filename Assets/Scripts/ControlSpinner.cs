using UnityEngine;
using UnityEngine.InputSystem;

public class ControlSpinner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float rotationSpeed = 150f;

    private float _inputDirection;

    // This method will be linked to the Input System
    // It reads a "Value" (like a joystick or arrow keys)
    public void OnRotate(InputAction.CallbackContext context)
    {
        // ReadValue<float> will be:
        // -1 when Left Arrow is pressed
        //  1 when Right Arrow is pressed
        //  0 when nothing is pressed
        _inputDirection = context.ReadValue<float>();
    }

    void Update()
    {
        // If _inputDirection is 0, no rotation happens.
        // We multiply by -1 because usually "Right" (positive) 
        // in Unity 2D rotation goes Counter-Clockwise.
        float rotationAmount = _inputDirection * rotationSpeed * Time.deltaTime * -1;

        transform.Rotate(0, 0, rotationAmount);
    }
}