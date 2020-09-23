using UnityEngine;
using UnityEngine.Events;

public class MouseEventsBehaviour : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
}