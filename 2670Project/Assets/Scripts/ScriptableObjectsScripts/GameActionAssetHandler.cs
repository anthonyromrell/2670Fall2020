using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActionAssetHandler : ScriptableObject
{
    public GameAction gameActionObj;
    public UnityEvent handleEvent;
    
    private void OnEnable()
    {
        gameActionObj.action += ActionHandler;
    }

    private void ActionHandler()
    {
        handleEvent.Invoke();
    }
}
