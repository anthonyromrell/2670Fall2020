using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class WizardBrain : AIBrainBase
{
    public override void Navigate(NavMeshAgent agent)
    {
        base.Navigate(agent);
        //Do what Wizards Do
    }
}
