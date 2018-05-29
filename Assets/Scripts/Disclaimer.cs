using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disclaimer : MonoBehaviour
{
	public GameObject DisclaimerCanvas;
	public GameManager gm;
	static bool yesPressed = false;

	public void Start(){
		//gm = GameManager.Instance();

		gm = GameObject.FindWithTag("SceneManager").GetComponent<GameManager>();
		if (yesPressed) {
			DisclaimerCanvas.gameObject.SetActive (false);
		}
	}

	public void YesButton()
	{
		GameManager.disclaimerPressed = false;
		DisclaimerCanvas.SetActive (false);
		yesPressed = true;
	}
}