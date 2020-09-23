using UnityEngine;

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void OnDebug(string obj)
    {
        Debug.Log(obj);
    }
}