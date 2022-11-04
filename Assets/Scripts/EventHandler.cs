using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class EventHandler : MonoBehaviour
{
    bool _isGameOver = false; 
    [SerializeField] GameObject _gameOverText;
    [SerializeField] PlayerHealth _health;
    [SerializeField] Player _player; 
    [SerializeField] Slider _healthBar; 

    public static EventHandler Instance; 

    // Start is called before the first frame update
    void Start()
    {
        _healthBar.minValue = 0;
        _healthBar.maxValue = _health._maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && _isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        _healthBar.value = _health._currentHealth;

    }
    public void InitiateGameOver()
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);
        Destroy(_player); 
    }
}
