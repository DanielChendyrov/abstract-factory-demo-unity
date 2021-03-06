using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFactory : EnemyFactory
{
    /// <summary>
    /// Create fast variant of Boss type while inheriting from EnemyFactory class
    /// </summary>
    /// <exception cref="System.ArgumentException"></exception>
    public override void CreateFastEnemy()
    {
        var portalTransformposition = portalTransform.transform.position;
        var fastBossGameObject = Resources.Load("Prefab/FastBoss") as GameObject;
        if (fastBossGameObject != null)
        {
            var fastBoss = Instantiate(
                fastBossGameObject.transform,
                new Vector3(
                    portalTransformposition.x,
                    portalTransformposition.y,
                    portalTransformposition.z
                ),
                Quaternion.identity
            );
        }
        else
        {
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }

    /// <summary>
    /// Create slow variant of Boss type while inheriting from EnemyFactory class
    /// </summary>
    /// <exception cref="System.ArgumentException"></exception>
    public override void CreateSlowEnemy()
    {
        var portalTransformposition = portalTransform.transform.position;
        var slowBossGameObject = Resources.Load("Prefab/SlowBoss") as GameObject;
        if (slowBossGameObject != null)
        {
            var slowBoss = Instantiate(
                slowBossGameObject.transform,
                new Vector3(
                    portalTransformposition.x,
                    portalTransformposition.y,
                    portalTransformposition.z
                ),
                Quaternion.identity
            );
        }
        else
        {
            throw new System.ArgumentException("Prefab does not exist.");
        }
    }
}
