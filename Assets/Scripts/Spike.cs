using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
