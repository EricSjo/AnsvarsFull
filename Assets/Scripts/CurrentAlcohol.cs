using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentAlcohol : MonoBehaviour
{
    private static double DEFAULT_ALCOHOL_CONTENT = 12;
	private bool isMale;
	private double weight;
	private double currentAlcoholLevel = 0;
	private double totalTimeDrinking = 0;
    private double totalWeightOfAlcohol = 0;

	public Text timeText;
	public Text weightText; 
	public Text displayText;
	public Button maleButton;
	public Button femaleButton;

    Color myColor;



    void Start ()
    {
        myColor = new Color();
        ColorUtility.TryParseHtmlString("#BA88B0", out myColor);
	}
	
	void Update ()
    {
        //LowerAlcoholLevel();
		showAlcoholLevel();
	}

    public void NewDrink()
    {
        totalWeightOfAlcohol += DEFAULT_ALCOHOL_CONTENT;
    }

    /*
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
    */

	public void setMale()
	{
		isMale = true;

        maleButton.GetComponent<Image>().color = myColor;
        femaleButton.GetComponent<Image>().color = Color.white;
	}

	public void setFemale()
	{
		isMale = false;

        femaleButton.GetComponent<Image>().color = myColor;
        maleButton.GetComponent<Image>().color = Color.white;
	}

	private void showAlcoholLevel()
	{

        setAlcoholLevel();

        if (currentAlcoholLevel > 0)
        {
            displayText.text = "Din nuvarande promillehalt är " + currentAlcoholLevel + "‰";

            if (currentAlcoholLevel > 500)
            {
                displayText.text = "Du har nu blod i ditt alkohol-omlopp.\nDin nuvarande promillehalt är " + currentAlcoholLevel
                    + "‰";

                if (currentAlcoholLevel >= 1000)
                {
                    displayText.text = "Du har nu inget blod i ditt alkohol-omlopp.\nDin nuvarande promillehalt är 100%";
                }
            }
        }

        else
        {
            displayText.text = "Din nuvarande promillehalt är 0‰";
        }
	}

	public void setWeight()
	{
		double.TryParse (weightText.text.Replace (',', '.'), out weight);
	}

    public void setTime()
    {
        double.TryParse(timeText.text.Replace (',', '.'), out totalTimeDrinking);
    }

    private void setAlcoholLevel()
    {
        if (!isMale)
        {
            currentAlcoholLevel = totalWeightOfAlcohol / (weight * 0.6) - (0.15 * totalTimeDrinking);
        }

        else
        {
            currentAlcoholLevel = totalWeightOfAlcohol / (weight * 0.7) - (0.15 * totalTimeDrinking);
        }

        if (currentAlcoholLevel > 1000)
        {
            currentAlcoholLevel = 1000;
        }

        currentAlcoholLevel = System.Math.Round(currentAlcoholLevel, 2);
    }
}
