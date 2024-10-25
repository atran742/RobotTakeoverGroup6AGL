using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isNear : MonoBehaviour
{
    public GameObject player; 
   public int sceneName;

   public GameObject respawnPoint;

   public void OnCollisionEnter2D(Collision2D collision)
   {
      Debug.Log(collision.gameObject.name);
      if (collision.gameObject.tag == "player")
      {
         SceneManager.LoadScene(sceneName);
         player.SetActive(false);
         points.addPoints(10);
         
         
      }
   }
}
