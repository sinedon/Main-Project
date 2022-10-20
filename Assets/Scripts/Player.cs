using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _xSpeed = 2f;
    [SerializeField] float _ySpeed = 2f;
    Rigidbody2D _playerRb; 

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = 0;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _playerRb.AddForce(Vector2.up * _ySpeed, ForceMode2D.Impulse);
        }
        if (_playerRb.velocity.y > _ySpeed)
        {
            _playerRb.velocity = Vector2.ClampMagnitude(_playerRb.velocity, _ySpeed);
        }

        Vector3 movement = new Vector3(_xSpeed * inputX, _ySpeed * inputY, 0);
        transform.Translate(movement);
    }
}
