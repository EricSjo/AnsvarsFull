using UnityEngine;
using System.Collections;
using System.Collections.Generic;       

public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;   

	public static bool disclaimerPressed = false;

	public GameObject DisclaimerPanel;


	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
		DontDestroyOnLoad(gameObject);
		if (disclaimerPressed == false) {
			DisclaimerPanel.SetActive (true);
		} else {
			DisclaimerPanel.SetActive (false);

		}

	}	

	void start(){
		DisclaimerPanel = GameObject.Find ("ModulPanel");
		//if(!disclaimerPressed){
		//	DisclaimerPanel.SetActive (false);
		//}
	}
}