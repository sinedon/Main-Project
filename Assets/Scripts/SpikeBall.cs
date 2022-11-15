using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBall : MonoBehaviour
{
    float _dirX;
    [SerializeField] float _moveSpeed = 4f;
    [SerializeField] Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _dirX = -1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(_dirX * _moveSpeed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Platform")
        {
            _dirX *= -1f;
        }
        if (collision.gameObject.tag == "Player")
        {
            var health = collision.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.DecreaseHealth(1);
            }
        }
    }
}
