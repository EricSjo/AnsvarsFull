using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using System;

public class SaveLoad : MonoBehaviour {

    public Text Ålder;
    public Text Vikt;
    public Text Kön;
    public Text LoadÅlder;
    public Text LoadVikt;
    public Text LoadKön;

    public Text tryText;

    FileStream file;
    float v;
    float å;
    private string vikt, ålder, kön;
    int on;

    public static List <Profile> saveProfiles = new List<Profile>();

    public void Start()
    {
    
    }

    public void LoadPlayerPrefs()
    {

        PlayerPrefs.GetFloat(vikt);
        PlayerPrefs.GetFloat(ålder);
        PlayerPrefs.GetString(kön);
        LoadVikt.text = v.ToString();
        LoadÅlder.text = å.ToString();
        LoadKön.text = kön;
        tryText.text = on.ToString();
    }
    public void SavePlayerPrefs()
    {
        on = Int32.Parse(ålder);
        PlayerPrefs.SetFloat(vikt, v = Convert.ToInt32(Vikt.text));
        PlayerPrefs.SetFloat(ålder, å = Convert.ToInt32(Ålder.text));
        PlayerPrefs.SetString(kön, Kön.text);
        PlayerPrefs.Save();
    }
}
