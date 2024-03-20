using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollision : MonoBehaviour
{
   public AudioClip coinCollisionSound; // เสียงที่เล่นเมื่อชนกันเหรียญ
   private AudioSource audioSource;
   private void Start()
   {
       audioSource = GetComponent<AudioSource>();
   }
   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Coin"))
       {
           // เล่นเสียงเมื่อชนกันเหรียญ
           if (coinCollisionSound != null)
           {
               audioSource.PlayOneShot(coinCollisionSound);
           }
       }
   }
}
