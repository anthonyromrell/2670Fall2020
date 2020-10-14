using UnityEngine;

public class CharacterMoveHV : CharacterBehaviour
{
    protected override void OnHorizontal()
    {
        hInput = Input.GetAxis("Horizontal")*moveSpeed.value;
    }
}