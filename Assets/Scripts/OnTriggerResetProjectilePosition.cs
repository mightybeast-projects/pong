using UnityEngine;

public class OnTriggerResetProjectilePosition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.position = Vector3.zero;
    }
}
