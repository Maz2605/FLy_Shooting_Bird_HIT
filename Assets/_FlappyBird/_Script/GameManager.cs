using GameTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float cooldown = 8f;
    private float spawnDelay;
    private void Update()
    {
        if (spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Wall, null, transform.position).Disable(10f);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}
