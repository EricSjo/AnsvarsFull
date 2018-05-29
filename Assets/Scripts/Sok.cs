using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Xml;
using System.Xml.Serialization;

public class Sok : MonoBehaviour {
    public Text Prisinklmoms;
    public Text Namn;
    public Text Namn2;
    public Text Volymiml;
    public Text PrisPerLiter;
    public Text Varugrupp;
    public Text Alkoholhalt;


    public Text text;
    public Text butText;
    public GameObject txt;
    public GameObject buttonPrefab;
    public Image GridSökResultat;
    List<Monster> MList = new List<Monster>();
    MonsterContainer monsterCollection;
    public GameObject sök;
    public GameObject info;
    public GameObject tillbaka;
    public GameObject tbks;
    public GameObject sökfält;
    TextAsset textAsset;
    XmlDocument xdc;
    public Monster[] Monsters;

    // Use this for initialization
    void Start () {
        //textAsset = (TextAsset)Resources.Load("artiklar", typeof(TextAsset)); ;
        //xdc = new XmlDocument();
        //xdc.LoadXml(textAsset.text);
        //monsterCollection = MonsterContainer.Load(Path.Combine(Application.dataPath, "Resources/artiklar.xml"));
        // path = "jar:file://" + Application.dataPath + "Resources/artiklar.xml";

        Monsters = new Monster[10];

        Monsters[0] = new Monster("Zubr", "", 27, 500, 40, "Öl", "4.5");
        Monsters[1] = new Monster("Klassiker", "", 30, 330, 72, "Cider", "7");
        Monsters[2] = new Monster("Dugges", "Tropic Thunder", 46, 330, 111, "Öl", "4.5");
        Monsters[3] = new Monster("Magners", "Cloudy Lemon", 32, 500, 64, "Cider", "4.5");
        Monsters[4] = new Monster("Hooch", "", 39, 330, 117, "Cider", "4.5");
        Monsters[5] = new Monster("Oppigårds", "Indian Tribute", 37, 330, 111, "Öl", "4.5");
        Monsters[6] = new Monster("Nebuchadnezzar", "", 50, 330, 150, "Öl", "8.5");
        Monsters[7] = new Monster("Somersby", "Pear", 34, 330, 102, "Cider", "4.5");
        Monsters[8] = new Monster("Canti", "Vitt", 29, 150, 193, "Vin", "12");
        Monsters[9] = new Monster("Yellowtail", "Rött", 37, 150, 247, "Vin", "13.5");

    }

    

    public void sok()
    {
        
        sökfält.SetActive(true);
        Debug.Log("Sök");
        MList.Clear();


        foreach (Monster i in Monsters)
        {

            if (text.text.ToLower().Equals(i.Namn.ToLower())) { 
                MList.Add(i);
            }
        }
        foreach (Monster m in MList)
        {
            Debug.Log(m.Namn);
        }

        creatButtons();
    }
    public void popup()
    {
        txt.SetActive(true);
        StartCoroutine(close());
        
    }

    public void creatButtons()
    {
        foreach(Monster i in MList)
        {
            makeButton(i);
        }
    }
    
    private void makeButton(Monster m)
    {
        GameObject button = Instantiate(buttonPrefab);
        button.transform.SetParent(GridSökResultat.transform);
        button.transform.Find("Text").GetComponent<Text>().text = m.Namn + " " + m.Namn2;
        button.GetComponent<Button>().onClick.AddListener(() => DryckInfo(m));
        button.transform.localScale = new Vector3(1, 1, 1);
    }
    public void DryckInfo(Monster a)
    {

        sök.SetActive(false);
        info.SetActive(true);
        tillbaka.SetActive(false);
        tbks.SetActive(true);

           
     

        Prisinklmoms.text = a.Prisinklmoms.ToString();
        Namn.text = a.Namn;
        Namn2.text = a.Namn2;
      Volymiml.text = a.Volymiml.ToString();
        PrisPerLiter.text = a.PrisPerLiter.ToString();
        Varugrupp.text = a.Varugrupp;
        Alkoholhalt.text = a.Alkoholhalt;


    }

    IEnumerator close()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        txt.SetActive(false);
    }

    public void gs()
    {
        info.SetActive(false);
        sök.SetActive(true);
        tbks.SetActive(false);  
        tillbaka.SetActive(true);
        
    }
}
