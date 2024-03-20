using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   Rigidbody rb;
   public float jumpForce;
   bool canJump;



   private void Awake()
   {
    rb = GetComponent<Rigidbody>();

   }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
 
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }

}

   private int totalCoins = 0; // จำนวนเหรียญที่เก็บไว้
   // ฟังก์ชัน OnTriggerEnter จะถูกเรียกเมื่อตัวละครชนกับเหรียญ
   private void OnTriggerEnter(Collider other)
   {

     // ตรวจสอบว่าตัวละครชนกับประตูชนะหรือวัตถุนับเหรียญหรือไม่
           if (other.CompareTag("WinDoor") || other.CompareTag("CoinCounter"))
           {
               // ตรวจสอบว่าเก็บเหรียญครบหรือไม่
               if (totalCoins >= 0 && other.CompareTag("WinDoor"))
               {
                   // โหลดซีนหน้าเกมชนะ
                   SceneManager.LoadScene("WinScene"); 
               }
               else
               {
                   // โหลดซีนหน้าเกมแพ้
                   SceneManager.LoadScene("LoseScene"); 
               }
           }
           // ตรวจสอบว่าตัวละครชนกับอุปสรรคหรือไม่
           else if (other.CompareTag("Obstacle"))
           {
               // โหลดซีนหน้าเกมแพ้
               SceneManager.LoadScene("LoseScene"); 
           }
   }
}