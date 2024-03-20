using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
   public void OnButtonClick()
   {
       Debug.Log("Button clicked!");
   }
   public void PlayGame()
   {
       SceneManager.LoadScene("Game"); // โหลดซีนเกมเมื่อคลิกปุ่มเล่นเกม
   }
   public void BackToMenu()
   {
       SceneManager.LoadScene("MainMenu"); // โหลดซีนหน้าเมนูเมื่อคลิกปุ่มกลับไปยังหน้าเมนู
   }

   public void About()
   {
       SceneManager.LoadScene("AboutScene"); 
   }

   public void Skin()
   {
       SceneManager.LoadScene("SkinScene"); 
   }

    public void QuitGame()
   {
       Debug.Log("Quit button clicked!");
       Application.Quit(); // ออกจากเกม
   }
}