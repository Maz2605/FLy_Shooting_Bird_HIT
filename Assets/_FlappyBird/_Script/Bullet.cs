using GameTool;
using UnityEngine;

public class Bullet : BasePooling
{
    [SerializeField] private Rigidbody2D rb;
    private float bulletSpeed = 7f;
    private void OnEnable()
    {
        //transform.localScale = new Vector3(1.5f, 1.5f, 0);
        rb.velocity = new Vector2(bulletSpeed, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            gameObject.SetActive(false);
        }
    }
}
