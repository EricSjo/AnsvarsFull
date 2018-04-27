using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Profile : MonoBehaviour {
    
    internal static Profile current;
    public Text Pname;
    public Text age;
    public Text weight;
    public Text gender;

    public Profile(Text name, Text age, Text weight, Text gender){
        name = this.Pname;
        age = this.age;
        weight = this.weight;
        gender = this.gender;
    }
}
