using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform player;
    private bool canHunt, canPatrol;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //StartCoroutine(Patrol());
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        agent.destination = player.position;
        var distance = agent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }
        yield return new WaitForSeconds(2f);
        
        if (canHunt)
        {
            StartCoroutine(OnTriggerEnter(other));
        }
        else
        {
            //StartCoroutine(Patrol());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
    }
}