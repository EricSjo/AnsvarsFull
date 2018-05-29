using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentAlcohol : MonoBehaviour
{
    private static double DEFAULT_ALCOHOL_CONTENT = 12;
    private System.DateTime firstDrink;
    private System.DateTime lastUpdate;
	private bool isMale;
	private double weight;
	private double currentAlcoholLevel;

	public Text timeText;
	public Text weightText; 
	public Text displayText;
	public Button maleButton;
	public Button femaleButton;


	void Start () {
		
	}
	
	void Update ()
    {
        LowerAlcoholLevel();
		showAlcoholLevel();
	}

    public void NewDrink()
    {
        if (currentAlcoholLevel == 0)
            firstDrink = System.DateTime.Now;
        
        if (!isMale)
        {
            currentAlcoholLevel += DEFAULT_ALCOHOL_CONTENT / (weight * 0.6);
        }

        else
        {
            currentAlcoholLevel += DEFAULT_ALCOHOL_CONTENT / (weight * 0.7);
        }
    }

    private void LowerAlcoholLevel()
    {
        if (System.DateTime.Now.Minute - lastUpdate.Minute > 1)
        {
            lastUpdate = System.DateTime.Now;

            if (currentAlcoholLevel > 0)
            {
                currentAlcoholLevel -= 0.0025 * System.DateTime.Now.Minute - firstDrink.Minute;
            }

            else
            {
                currentAlcoholLevel = 0;
            }
        }
    }

	public void setMale()
	{
		isMale = true;
	}

	public void setFemale()
	{
		isMale = false;
	}

	private void showAlcoholLevel()
	{
		displayText.text = "Din nuvarande promillehalt är " + currentAlcoholLevel + "‰.";
	}

	public void setWeight()
	{
		//weight = double.TryParse(weightText.text);

		double.TryParse (weightText.text.Replace (',', '.'), out weight);
			
	}
}
