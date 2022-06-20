using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Inititates enemy's parameters
    protected float moveSpeed = 0f;
    public int health = 0;

    Timer timer;

    // Contains the types of enemies
    public enum EnemyType
    {
        Boss,
        Creep
    }

    // Abstract method to return enemy type
    public abstract EnemyType GetEnemyType();

    // Start is called before the first frame update
    void Start()
    {
        // Initiates timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;

        // Destroys the game object after some time to save memory
        if (timer.Finished)
        {
            Destroy(gameObject);
        }
    }
}
