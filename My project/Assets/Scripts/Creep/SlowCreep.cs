using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCreep : Creep
{
    void Awake()
    {
        // Initiates the variant's parameters
        moveSpeed = 2f;
        health = 1;
    }
}
