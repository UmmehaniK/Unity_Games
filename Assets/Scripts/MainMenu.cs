using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playbtn()
    {
         SceneManager.LoadScene("Mission");
    }
    public void quitbtn()
    {
         Debug.Log("Quit");
	     Application.Quit();
    }
  
}
