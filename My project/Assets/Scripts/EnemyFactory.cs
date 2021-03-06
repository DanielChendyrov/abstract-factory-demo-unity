using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyFactory : MonoBehaviour
{
    // Gets the transform attribute of the portal (the factory)
    public Transform portalTransform;

    /// <summary>
    /// Abstract method to create slow variant of enemies
    /// </summary>
    public abstract void CreateSlowEnemy();

    /// <summary>
    /// Abstract method to create fast variant of enemies
    /// </summary>
    public abstract void CreateFastEnemy();
}
