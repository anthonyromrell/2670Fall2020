using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public bool canRun;
    public string password;
    public int number;
    
    // Start is called before the first frame update
    private void Start()
    {
        if (canRun)
        {
            Debug.Log("Running");
        }    
    }

    // Update is called once per frame
    private void Update()
    {
        if (!canRun)
        {
            Debug.Log("Running");
        }

        Debug.Log(password == "OU812" ? "Correct" : "Incorrect");

        Debug.Log(number >= 7 ? "Greater Than 7." : "Less Than 7.");
    }
}
