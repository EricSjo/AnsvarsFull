using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;


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
    TEST st;
    public GameObject sök;
    public GameObject info;
    public GameObject tillbaka;
    public GameObject tbks;
    public GameObject sökfält;

    // Use this for initialization
    void Start () {
       monsterCollection = MonsterContainer.Load(Path.Combine(Application.dataPath, "XML/artiklar.xml"));
        
    }

    public void sok()
    {
        sökfält.SetActive(true);
        Debug.Log("Sök");
        MList.Clear();
        foreach (Monster i in monsterCollection.Monsters)
        {
            int nr = 0;

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

 

    // Update is called once per frame

}
