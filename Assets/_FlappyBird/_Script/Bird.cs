using GameTool;
using UnityEngine;

public class Bird : MonoBehaviour       
{
    private float jumpForce = 18f;
    private float cooldown = 0.3f;
    private float boundTop = 4.2f;
    private float boundBot = -4.2f;
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
        if(transform.position.y >= boundTop) transform.position = new Vector2(transform.position.x, boundBot);
        if(transform.position.y <= boundBot) transform.position = new Vector2(transform.position.x, boundTop);
        if (spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, null, transform.position).Disable(2f);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}