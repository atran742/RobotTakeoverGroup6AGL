using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    

    public string sceneName;
    
    public GameObject player;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.tag == "player"&& Calculator.key)
        {
            SceneManager.LoadScene(sceneName);
            player.SetActive(false);
        }
        
    }
}
