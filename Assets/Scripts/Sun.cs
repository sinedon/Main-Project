using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    float _dirY;
    [SerializeField] float _moveSpeed = 4f;
    [SerializeField] Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _dirY = -1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Running");
        rb.velocity = new Vector2(rb.velocity.x, _dirY * _moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Platform")
        {
            _dirY *= -1f;
        }
        if (collision.gameObject.tag == "Player")
        {
            var health = collision.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.DecreaseHealth(1);
            }
            //Destroy(collision.gameObject); 
        }
    }
}
