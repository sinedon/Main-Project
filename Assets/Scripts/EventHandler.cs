using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventHandler : MonoBehaviour
{
    bool _isGameOver = false; 
    [SerializeField] GameObject _gameOverText; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && _isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void DecreaseHealth()
    {
       
    }
    public void InitiateGameOver()
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);
    }
}
