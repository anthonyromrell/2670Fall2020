using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class CharacterStateMachineData : ScriptableObject
{
    public enum characterStates
    {
        StandardWalk,
        NoGravityWalk,
        WallCrawl,
        KnockBack
    }
    public characterStates value;
    

    public void StandardWalk()
    {
        value = characterStates.StandardWalk;
    }
    
    public void NoGravityWalk()
    {
        value = characterStates.NoGravityWalk;
    }
    
    public void WallCrawl()
    {
        value = characterStates.WallCrawl;
    }
    
    public void KnockBack()
    {
        value = characterStates.KnockBack;
    }
}