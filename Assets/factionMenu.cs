using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;
using System.Xml;

public class factionMenu : MonoBehaviour {


    public TextAsset Text_Asset;

	// Use this for initialization
	void Start () {
        if (Text_Asset == null) throw new System.Exception("Text_Asset not defined on Binder Script!");

        XmlDocument xd = new XmlDocument();
         xd.LoadXml(Text_Asset.text);

        GameObject contentGO = GameObject.Find("Content");
        GameObject factionButtonPrefab = GameObject.Find("factionButtonPrefab");
        int factionIndex = 0;

        

        if(xd.DocumentElement.HasChildNodes)
        {
            foreach (XmlNode node in xd.DocumentElement.ChildNodes)
            {
                print(node.ChildNodes);
                GameObject newFaction = Instantiate(factionButtonPrefab);
                //newFaction.GetComponentInChildren<Image>().sprite =  
            }
        }


        ////if (xd.DocumentElement.HasChildNodes)
        ////{
        ////    Dictionary<string, Text> textComponents = new Dictionary<string, Text>(2);
        ////    Text[] t = gameObject.GetComponentsInChildren<Text>();

        ////    foreach (Text itm in t)
        ////    {
        ////        textComponents.Add(itm.name, itm);
        ////    }
                

        ////    foreach (XmlNode node in xd.DocumentElement.ChildNodes)
        ////    {
        ////        if (textComponents.ContainsKey(node.Name))
        ////            textComponents[node.Name].text = node.InnerText;
        ////        print(node.Name);
        ////        print(node.InnerText);
        ////    }
        ////}
    } 
	
	// Update is called once per frame
	void Update () {
	
	}
}
