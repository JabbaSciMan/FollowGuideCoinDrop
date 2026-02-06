using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ClickToRestart : MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake() => _mainCamera = Camera.main;

    public void OnRestartClick(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = _mainCamera.ScreenPointToRay(mousePos);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        // Check if the player clicked specifically ON this object
        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            // Reloads the scene currently open
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}