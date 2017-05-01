using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Canvas tutorial;
	public Button level1Text;
	public Button level2Text;
	public Button exitText;

	// Use this for initialization
	void Start ()
	{
		tutorial = tutorial.GetComponent<Canvas>();
		level1Text = level1Text.GetComponent<Button>();
		level2Text = level2Text.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		tutorial.enabled = false;
	}

	public void TutorialPress()
	{
		tutorial.enabled = true;
		level1Text.enabled = false;
		level2Text.enabled = false;
	}

	public void NoPress() //this function will be used for our "NO" button in our Quit Menu
		
	{
		tutorial.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
		level1Text.enabled = true; //enable the Play and Exit buttons again so they can be clicked
		level2Text.enabled = true;}
	
	public void StartLevel1()
	{
		//load level 1
		SceneManager.LoadScene (1);
	}
	
	public void StartLevel2()
	{
		//load level 2
		SceneManager.LoadScene (2);
	}

	public void ExitGame() {
			Application.Quit ();
	}

}
