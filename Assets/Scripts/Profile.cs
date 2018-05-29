using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Profile : MonoBehaviour {
    
    internal static Profile current;
	public double weight;
    public bool isMale;

	public Profile(double weight, bool isMale){
  
        weight = this.weight;
		isMale = this.isMale;
    }
}
