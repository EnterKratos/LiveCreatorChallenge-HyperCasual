using UnityEngine;
using UnityEngine.InputSystem;

public class RotateOnDrag : MonoBehaviour
{
    private Vector3 _mousePosition;
    private Quaternion _startRotation;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _mousePosition = Mouse.current.position.ReadValue();
            _startRotation = transform.rotation;
        }
        else if (Mouse.current.leftButton.isPressed)
        {
            var currentDistanceBetweenPositions = Mouse.current.position.ReadValue().x - _mousePosition.x;
            transform.rotation = _startRotation * Quaternion.Euler(Vector3.up * (currentDistanceBetweenPositions / Screen.width * -360));
        }
    }
}
