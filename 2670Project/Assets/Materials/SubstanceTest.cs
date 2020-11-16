using System.Collections;
using System.Collections.Generic;
using Substance.Game;
using UnityEngine;

public class SubstanceTest : MonoBehaviour
{
    public Substance.Game.SubstanceGraph obj;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetInputBool("window", false);
        obj.SetInputFloat("metal_rust_level", 1f);
        obj.SetInputFloat("peeling_amount", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
