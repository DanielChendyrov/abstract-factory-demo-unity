using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCreep : Creep
{
    void Awake()
    {
        // Initiates the variant's parameters
        moveSpeed = 4f;
        health = 1;
    }
}
