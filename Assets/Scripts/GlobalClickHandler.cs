using UnityEngine;
using UnityEngine.InputSystem;

public class GlobalClickHandler : MonoBehaviour
{
    private Camera _mainCamera;
    private void Awake() => _mainCamera = Camera.main;

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = _mainCamera.ScreenPointToRay(mousePos);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit.collider != null && hit.collider.CompareTag("Crate"))
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
