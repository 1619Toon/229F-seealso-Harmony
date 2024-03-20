using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollectioin : MonoBehaviour
{
   public TextMeshProUGUI coinCountText; // อ้างอิงไปยัง UI Text ที่ใช้แสดงค่าจำนวนเหรียญ
   private int coinCount = 0; // จำนวนเหรียญที่เก็บไว้
   // ฟังก์ชัน OnTriggerEnter จะถูกเรียกเมื่อตัวละครชนกับเหรียญ
   private void OnTriggerEnter(Collider other)
   {
       // ตรวจสอบว่าตัวละครชนกับเหรียญหรือไม่
       if (other.CompareTag("Coin"))
       {
           // เพิ่มจำนวนเหรียญที่เก็บไว้
           coinCount++;
           // ปรับปรุงแสดงค่าเหรียญบน UI
           UpdateCoinCountUI();
           // ทำลายเหรียญที่ถูกเก็บ
           Destroy(other.gameObject);
       }
   }
   // ฟังก์ชันนี้ใช้ในการอัปเดต UI Text เพื่อแสดงค่าจำนวนเหรียญที่เก็บไว้
   private void UpdateCoinCountUI()
   {
       coinCountText.SetText("Coins: " + coinCount.ToString());
   }
}