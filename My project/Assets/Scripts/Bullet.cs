using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Controls bullet behavior
    [SerializeField]
    Rigidbody2D rb2d;
    float speed = 1000;

    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        // Initializes the Timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 15;
        timer.Run();

        // Yeets the bullet
        rb2d.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    private void Update()
    {
        // Destroys the bullet after some time to save memory
        if (timer.Finished)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Decrease enemy's health when hit by the bullet
        collision.gameObject.GetComponent<Enemy>().health--;

        // Kills the enemy if it's health reaches zero
        if (collision.gameObject.GetComponent<Enemy>().health == 0)
        {
            Destroy(collision.gameObject);
        }

        // Destroy the bullet
        Destroy(gameObject);
    }
}
