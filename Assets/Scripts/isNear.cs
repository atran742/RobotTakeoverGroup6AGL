using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class isNear : MonoBehaviour
{
    
    public string sceneName;
    
    public GameObject player;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collision.tag == "player")
        {
            SceneManager.LoadScene(sceneName);
            player.SetActive(false);
            points.AddPoints(10);
        }
    }
}
