using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCreep : Creep
{
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        // Initiates the variant's parameters
        moveSpeed = 4f;
        health = 1;

        // Initiates timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();
    }
}
