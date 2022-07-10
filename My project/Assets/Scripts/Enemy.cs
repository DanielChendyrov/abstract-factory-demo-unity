using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Inititates enemy's parameters
    protected float moveSpeed = 0f;
    public int health = 0;

    // Contains the types of enemies
    public enum EnemyType
    {
        Boss,
        Creep
    }

    // Abstract method to return enemy type
    public abstract EnemyType GetEnemyType();

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;
    }
}
