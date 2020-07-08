using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public GameObject winGame;
    public GameObject restart;

    private void Start()
    {
        winGame.SetActive(false);
        restart.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            winGame.SetActive(true);
            restart.SetActive(true);
        }

    }
   public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
