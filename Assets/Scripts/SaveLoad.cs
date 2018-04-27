using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveLoad : MonoBehaviour {

    public static List <Profile> saveProfiles = new List<Profile>();

    public void Save()
    {
        saveProfiles.Add(Profile.current);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedProfiles.gd");
        bf.Serialize(file, SaveLoad.saveProfiles);
        file.Close();

        Debug.Log("0");
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedProfile.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedProfile.gd", FileMode.Open);
            SaveLoad.saveProfiles = (List<Profile>)bf.Deserialize(file);
            file.Close();

            Debug.Log("1");

        }
    }
}
