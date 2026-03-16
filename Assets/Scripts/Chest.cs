using System;
using UnityEngine;

public class Chest : MonoBehaviour
{
  Animator animator;
  bool opned = false;
  void Start()
  {
    animator = GetComponent<Animator>();
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player") && KeyPickup.hasKey && !opned)
    {
      OpenChest();
    }
  }

  void OpenChest()
  {
    opned = true;
    animator.SetTrigger("Opened");
  }
  
}
