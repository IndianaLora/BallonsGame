using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

   public GameObject CamaraGameOver;

     private void OnTriggerEnter2D(Collider2D collision){
      
      if(collision.gameObject.tag == "ButtonWall" || collision.gameObject.tag == "TopWall")
      {
         Destroy(this.gameObject);
        GameController.Score = 0;
         CamaraGameOver.SetActive(true);
      }
   }
}
