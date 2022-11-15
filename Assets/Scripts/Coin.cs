using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioSource coinSoundEffect;
    public static int _numCoins = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        _numCoins++;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            coinSoundEffect.Play();
            Destroy(this.gameObject);
            _numCoins--;
            if (_numCoins == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
