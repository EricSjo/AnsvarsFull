using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class temp : MonoBehaviour {
    //public string url = "https://www.systembolaget.se/api/assortment/products/xml/xml.xml";
    // Use this for initialization
    void Start () {
        var monsterCollection = MonsterContainer.Load(Path.Combine(Application.dataPath, "artiklar.xml"));
        //StartCoroutine(LoadBooze());
      //  Debug.Log(monsterCollection.Monsters[0].Namn);
    }

    //IEnumerator LoadBooze()
    //{


    //    using (WWW www = new WWW(url))
    //    {
    //        yield return www;
    //        var monsterCollection = MonsterContainer.LoadFromText(www.text);

    //        Debug.Log(monsterCollection.Monsters[0].Namn);
    //    }
    //}
}
