using UnityEngine;

public class InstancerBehaviour : MonoBehaviour
{
    public GameObject prefab;

    public void Instance()
    {
        var location = transform.position;
        var newObj = Instantiate(prefab);
    }
}
