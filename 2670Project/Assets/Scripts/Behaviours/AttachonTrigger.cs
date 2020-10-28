using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var otherTag = other.CompareTag("Platform");
        if (otherTag)
        {
            transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
