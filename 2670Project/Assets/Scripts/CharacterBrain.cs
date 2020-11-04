using UnityEngine;

[CreateAssetMenu]
public class CharacterBrain : ScriptableObject
{
    public Vector3Data position;

    public Vector3 Move( float speed)
    {
        var newValue = position.value * speed;
        return newValue;
    }

    public void Change(Vector3Data data)
    {
        position = data;
    }
}