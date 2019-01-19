using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;  //lock fps

public class PauseMenu : MonoBehaviour {

	public static bool GameisPaused = false;
	
	public FirstPersonController fpsController;
	
	public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameisPaused)
			{
				Resume();
			} else 
			{
				Pause();
			}
		}
	}
	
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameisPaused = false;
		fpsController.enabled = true;
	}
	
	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameisPaused = true;
		fpsController.enabled = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

	}
	
	public void LoadMenu()
	{
		Debug.Log("Loading menu...");
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}  ////devido a um bug que não fomos capazes ainda de resolver, deixamos isto desactivo temporariamente.
	
	public void QuitGame()
	{
		Debug.Log("Quitting game...");
		Application.Quit();
	}
	
}
