using UnityEngine;

public class WSInputHandler : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _minY, _maxY;

    void FixedUpdate()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        ClampPosition(GetInput());
    }

    private void ClampPosition(Vector3 currentPosition)
    {
        float clampedY = Mathf.Clamp(currentPosition.y, _minY, _maxY);
        Vector3 clampedPosition = new Vector3(currentPosition.x, clampedY, 0);
        transform.position = clampedPosition;
    }

    private Vector3 GetInput()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        Vector3 currentPosition = gameObject.transform.position;
        currentPosition += new Vector3(0, verticalAxis, 0) * _movementSpeed;
        return currentPosition;
    }
}
