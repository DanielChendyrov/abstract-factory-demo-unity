using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBoss : Boss
{
    void Awake()
    {
        // Initiates the variant's parameters
        moveSpeed = 2f;
        health = 2;
    }
}
