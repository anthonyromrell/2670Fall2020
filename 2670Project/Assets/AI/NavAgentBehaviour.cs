using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    public GameAction gameActionObj;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
        gameActionObj.transformAction += HandleTransform;
    }

    private void HandleTransform(Transform obj)
    {
        destination = obj;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
}