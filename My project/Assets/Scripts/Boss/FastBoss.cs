using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBoss : Boss
{
    // Start is called before the first frame update
    void Start()
    {
        // Initiates the variant's parameters
        moveSpeed = 2f;
        health = 2;
    }
}
