using GameTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float jumpForce = 10f;
    private float cooldown = 0.5f;
    private float spawnDelay ;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnDelay = cooldown;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)) 
        {
            rb.velocity = new Vector2(0f, jumpForce);
        }
        if(spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, null, transform.position);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}