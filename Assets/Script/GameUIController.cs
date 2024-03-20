using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameUIController : MonoBehaviour
{
   public GameObject pauseMenuUI;
   private bool isPaused = false;
   void Update()
   {
       if (Input.GetKeyDown(KeyCode.Escape)) // กดปุ่ม Escape บนคีย์บอร์ดเพื่อหยุดเล่นชั่วคราว
       {
           if (isPaused)
           {
               ResumeGame();
           }
           else
           {
               PauseGame();
           }
       }
   }
   public void PauseGame()
   {
       if (!isPaused)
       {
           Time.timeScale = 0f; // หยุดการเล่นเกมชั่วคราว
           pauseMenuUI.SetActive(true); // เปิดเมนูหยุดเล่นชั่วคราว
           isPaused = true;
       }
   }
   public void ResumeGame()
   {
       if (isPaused)
       {
           Time.timeScale = 1f; // เริ่มเล่นเกมอีกครั้ง
           pauseMenuUI.SetActive(false); // ปิดเมนูหยุดเล่นชั่วคราว
           isPaused = false;
       }
   }
   public void LoadNextLevel()
   {
       // โหลดซีนเกมถัดไป
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void QuitGame()
   {
       // ออกจากเกม
       Application.Quit();
   }
}