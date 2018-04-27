using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public void MainMenu ()
	{
		SceneManager.LoadScene (0);
	}

	public void Sök()
	{
		SceneManager.LoadScene (1);
	}

	public void Tips()
	{
		SceneManager.LoadScene (2);
	}

	public void Favoriter ()
	{
		SceneManager.LoadScene (3);
	}

	public void Nulägeskoll ()
	{
		SceneManager.LoadScene (4);
	}

	public void Kalkylator()
	{
		SceneManager.LoadScene (5);
	}
		
	public void KvällsTips()
	{
		SceneManager.LoadScene (6);
	}

	public void MorgonTips()
	{
		SceneManager.LoadScene (7);
	}

	public void Profil ()
	{
		SceneManager.LoadScene (8);
	}

	public void Avsluta()
	{
		Application.Quit ();
	}
    public void DryckInfo()
    {
        SceneManager.LoadScene(9);
    }
}
