using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("How fast the object spins. Positive = Clockwise, Negative = Counter-Clockwise")]
    [SerializeField] private float rotationSpeed = 100f;

    void Update()
    {
        // Rotates the object around the Z axis (the 2D rotation axis)
        // Time.deltaTime ensures it spins at the same speed regardless of frame rate
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}