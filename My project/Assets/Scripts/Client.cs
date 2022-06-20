using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    // Gets the transform attribute of portals into a list
    List<Transform> portals;
    int i = 0;

    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        portals = new List<Transform>();

        // Initiates timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = Random.Range(2, 5);
        timer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        // Spawns a portal at mouse's Y level on input
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Gets mouse position and converts it into world position, also hard code the x and z
            var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;
            mouseWorldPos.x = -8;

            // Gets the prefab from Resourses folder and spawns it
            var bossPortalGameObject = Resources.Load("Prefab/BossPortal") as GameObject;
            if (bossPortalGameObject != null)
            {
                var bossPortal = Instantiate(
                    bossPortalGameObject.transform,
                    mouseWorldPos,
                    Quaternion.identity
                );
                // Assigns the factory type to portal
                bossPortal.gameObject.AddComponent<BossFactory>();
                // Adds the portal into list
                portals.Add(bossPortal);
            }
            else
            {
                // Throw an error if the prefab doesn't exist
                throw new System.ArgumentException("Prefab does not exist.");
            }
        }

        // Spawns a portal at mouse's Y level on input
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Gets mouse position and converts it into world position, also hard code the x and z
            var mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;
            mouseWorldPos.x = -8;

            // Gets the prefab from Resourses folder and spawns it
            var creepPortalGameObject = Resources.Load("Prefab/CreepPortal") as GameObject;
            if (creepPortalGameObject != null)
            {
                var creepPortal = Instantiate(
                    creepPortalGameObject.transform,
                    mouseWorldPos,
                    Quaternion.identity
                );
                // Assigns the factory type to portal
                creepPortal.gameObject.AddComponent<CreepFactory>();
                // Adds the portal into list
                portals.Add(creepPortal);
            }
        }

        // Spawns an enemy based on the factory type it belongs to (boss/creep) according to the portal when Timer finishes
        if (timer.Finished)
        {
            // This entire section is basically a for() loop
            if (i < portals.Count)
            {
                portals[i].gameObject.GetComponent<EnemyFactory>().portalTransform = portals[i];

                // Spawns an enemy of random variant (fast/slow) on the portal's position
                if (Random.Range(0, 2) == 0)
                {
                    portals[i].gameObject.GetComponent<EnemyFactory>().CreateFastEnemy();
                }
                else
                {
                    portals[i].gameObject.GetComponent<EnemyFactory>().CreateSlowEnemy();
                }
                i++;
            }
            else
            {
                i = 0;
            }

            // Restarts the Timer
            timer.Duration = Random.Range(2, 5);
            timer.Run();
        }
    }
}
