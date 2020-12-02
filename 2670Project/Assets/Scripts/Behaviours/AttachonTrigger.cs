using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    public StringData tagObj;
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        var newObj = GetComponent<IDHolder>();
        if (newObj == null) return;
        if (idObj == newObj.idObj)
            transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
