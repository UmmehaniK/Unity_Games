using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
   [Header("All Menus")]
   public GameObject pause;
   public GameObject endGame;

   public static bool GameIsStopped = false;

   private void Update()
   {
	   if(Input.GetKeyDown(KeyCode.Escape))
	   {
		   if(GameIsStopped)
		   {
			   Resume();
			   Cursor.lockState = CursorLockMode.Locked;

		   }
		   else
		   {
			   Pause();
			   Cursor.lockState = CursorLockMode.None;

		   }
	   }
   }

   public void Resume()
   {
	   pause.SetActive(false);
	   Time.timeScale = 1f;
	   Cursor.lockState = CursorLockMode.Locked;
	   GameIsStopped = false;
   }

   public void Restart()
   {
	   SceneManager.LoadScene("Mission");
   }

   public void LoadMenu()
   {
	   Time.timeScale = 1f;
	   SceneManager.LoadScene("Menu");
   }

   public void QuitGame()
   {
	   Debug.Log("Quit");
	   Application.Quit();
   }

   public void Pause()
   {
	   pause.SetActive(true);
	   Time.timeScale = 0f;
	   //Cursor.lockState = CursorLockMode.Locked;
	   GameIsStopped = true;

   }

}
