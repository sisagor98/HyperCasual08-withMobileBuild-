using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public float movespeed = 4f;
    [SerializeField]
    private bool moveLeft;
  

    private void Update()
    {
        if (moveLeft)
        {

            Vector3 temp = transform.position;
            temp.x -= movespeed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x += movespeed * Time.deltaTime;
            transform.position = temp;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "bounce")
        {
            moveLeft = !moveLeft;

           // Debug.Log("COllide");
        }
        if(other.tag == "Player")
        {
           // Debug.Log("COllide with Player"+Count);
           
               // Destroy(this.gameObject, 2f);
                Restart();    
           
        }
       
        
    }
    void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
