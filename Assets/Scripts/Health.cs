using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int _maxHealth = 5; 
    [SerializeField] public int _currentHealth = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _currentHealth = _maxHealth; 
    }

    public void DecreaseHealth(int health)
    {
        _currentHealth -= health;
    }
}
