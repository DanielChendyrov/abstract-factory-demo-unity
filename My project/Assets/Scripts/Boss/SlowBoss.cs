using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBoss : Boss
{
    void Awake()
    {
        // Initiates the variant's parameters
        moveSpeed = 1f;
        health = 2;
    }
}
