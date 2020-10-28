using UnityEngine;
using UnityEngine.Events;

public class GameAction : MonoBehaviour
{
    public UnityAction action;

    public void Raise()
    {
        action?.Invoke();
    }
}
