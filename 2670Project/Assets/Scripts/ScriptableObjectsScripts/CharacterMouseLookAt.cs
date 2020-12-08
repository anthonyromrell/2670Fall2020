using UnityEngine;

public class CharacterMouseLookAt : CharacterBehaviour
{
    public Vector3Data mouseLocation;

    protected override void OnHorizontal()
    {
        Transform transform1;
        (transform1 = transform).LookAt(mouseLocation.value);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.z = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}