using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         Collect();
      }
   }

   void Collect()
   {
      ScoreManager.instance.AddScore(1);
      Destroy(gameObject);
   }
   
}
