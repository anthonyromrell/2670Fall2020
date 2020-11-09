using UnityEngine;

public class CharacterWithLookAt : MonoBehaviour
{
    private Vector3 rotation = Vector3.zero;
    
    public void LookAt (Transform lookObj)
    {
        transform.LookAt(lookObj);
        rotation = transform.eulerAngles;
        rotation.x -= 90;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
