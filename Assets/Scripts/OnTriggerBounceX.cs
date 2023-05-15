using UnityEngine;

public class OnTriggerBounceX: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        ProjectileBehaviour pb = other.gameObject.GetComponent<ProjectileBehaviour>();
        if(pb != null)
            pb.CurrentMovementVector = GenerateBounceVector(pb.CurrentMovementVector);
    }

    private Vector3 GenerateBounceVector(Vector3 pbCurrentMovementVector)
    {
        Vector3 newVector = Vector3.Reflect(pbCurrentMovementVector, Vector3.right);
        return newVector;
    }
}