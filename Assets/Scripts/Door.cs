using UnityEngine;

public class Door : MonoBehaviour
{
   Animator animator;
   bool opened  = false;

   void Start()
   {
      animator = GetComponent<Animator>();
   }
   
   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player") && KeyPickup.hasKey && !opened)
      {
         OpenDoor();
      }
   }

   void OpenDoor()
   {
      opened = true;
      animator.SetBool("opened", true);
   }
   
}
