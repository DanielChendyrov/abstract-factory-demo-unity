using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBoss : Boss
{
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        // Initiates the variant's parameters
        moveSpeed = 1f;
        health = 2;

        // Initiates timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();
    }
}
