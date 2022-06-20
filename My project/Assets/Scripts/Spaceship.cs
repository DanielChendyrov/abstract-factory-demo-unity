using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    // Gets the prefab of the bullet by dragging it in the inspector
    [SerializeField]
    GameObject bulletPrefab;

    // Controls ship behavior
    float speed = 10f;
    Vector2 movement;

    [SerializeField]
    Rigidbody2D rb2d;

    // Update is called once per frame
    void Update()
    {
        // Creates a bullet object on the ship's position and sets it direction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(
                bulletPrefab.transform,
                transform.position,
                Quaternion.Euler(0, 0, 90)
            );
        }
        // Uses the Unity input system to control the ship
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // FixedUpdate is called once per fixed frame of the physics engine (50fps)
    private void FixedUpdate()
    {
        // Moves the ship in the direction of input
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
    }
}
