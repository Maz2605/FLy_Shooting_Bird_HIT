using GameTool;
using UnityEngine;

public class Bullet : BasePooling
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sr;
    private float bulletSpeed = 7f;
    public float damage = 1f;
    private void OnEnable()
    {
        //transform.localScale = new Vector3(1.5f, 1.5f, 0);
        rb.velocity = new Vector2(bulletSpeed, 0f);

        var score = GameData.Instance.score;
        var index = score / 10;

        sr.sprite = GameData.Instance.bulletData.sprites[index];
        damage = GameData.Instance.bulletData.damage[index];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            var block = collision.gameObject.GetComponent<Block>();
            block.TakeDamege(damage);
            gameObject.SetActive(false);
        }
    }
}
