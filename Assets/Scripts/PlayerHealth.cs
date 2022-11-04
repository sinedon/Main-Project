using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] float _damageInvulTime = 2f;
    bool _damageAllowed = true;

    // Start is called before the first frame update
    void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public new void DecreaseHealth(int health)
    {
        if (_damageAllowed == true)
        {
            _currentHealth -= health;
            Debug.Log("Activated");
            StartCoroutine(DamageCounterReset());
        }
        if (_currentHealth <= 0)
        {
            //Call Game Over
        }
    }

    private IEnumerator DamageCounterReset()
    {
        Debug.Log("DamageCounterReset");
        _damageAllowed = false;
        yield return new WaitForSeconds(_damageInvulTime);
        _damageAllowed = true;
    }
}
