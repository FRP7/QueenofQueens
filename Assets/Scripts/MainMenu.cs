using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	void Start()
	{
		Screen.lockCursor = false;
		Cursor.visible = true;
	}
	
	public void GoToMenu ()
	{
		SceneManager.LoadScene("Menu");
	}

	public void PlayGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void Credits() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}
	
	public void QuitGame ()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
