using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APKCalculator : MonoBehaviour
{
	private decimal apk;
	private bool priceDone = false;
	private bool volumeDone = false;
	private bool alcoholDone = false;
	private bool nameDone = false;
    private double priceValue;
    private double volumeValue;
    private double alcoholValue;

	public Text drinkName;
	public Text price;
	public Text volume;
	public Text alcohol;
	public Text APK;


	public void FieldDone()
	{
		if (priceDone && volumeDone && alcoholDone)
		{
			OutputAPK ();
		}

		else
			APK.text = "APK: ";
	}

	public void OutputAPK()
	{
        apk = new decimal(volumeValue * alcoholValue / 100 / priceValue);
		apk = decimal.Round(apk, 3);
		APK.text = "APK: " + apk;
	}

	public void PriceDoneCheck()
	{
        if (double.TryParse (price.text.Replace(',', '.'), out priceValue))
		{
			priceDone = true;
		}

		else
			priceDone = false;

		FieldDone ();
	}

	public void VolumeDoneCheck()
	{
        if (double.TryParse (volume.text.Replace(',', '.'), out volumeValue))
		{
			volumeDone = true;
		}

		else
			volumeDone = false;

		FieldDone ();
	}

	public void AlcoholDoneCheck()
	{
        if (double.TryParse (alcohol.text.Replace(',', '.'), out alcoholValue))
		{
			alcoholDone = true;
		}

		else
			alcoholDone = false;

		FieldDone ();
	}
}
