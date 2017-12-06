using System.Collections;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {

	public Text text;
    public GameObject content;
 
    void Start() {
        string Path = Application.dataPath + "/Data/Leaderboard.xml";
 
        XmlDocument doc = new XmlDocument();
 
        if (!System.IO.File.Exists(Path)) {
            Debug.Log("File not found");
        }
 
        else {
 
            doc.Load(Path);
 
            XmlNodeList elemList = doc.GetElementsByTagName("SurvivalTime");
            for (int i = 0; i < elemList.Count; i++) {
                    text = Instantiate<Text>(text);
                    text.transform.SetParent(content.transform, false);
                    text.text = elemList[i].InnerXml;
            }
        }
    }
 
    public void writeToXML() {
        text = FindObjectOfType<Text>();
        string Path = Application.persistentDataPath + "/Leaderboard.xml";
 
        XmlDocument doc = new XmlDocument();
 
        if (!System.IO.File.Exists(Path)) {
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            XmlComment comment = doc.CreateComment("This is a generated XML File");
            XmlElement Leaderboard = doc.CreateElement("Leaderboard");
            XmlElement survivalTime = doc.CreateElement("SurvivalTime");
 
            survivalTime.InnerText = text.text;
 
            doc.AppendChild(declaration);
            doc.AppendChild(comment);
            doc.AppendChild(Leaderboard);
 
            Leaderboard.AppendChild(survivalTime);
 
            //Save document
            doc.Save(Path);
        }
 
        else {
            doc.Load(Path);
 
            // Get root element
            XmlElement root = doc.DocumentElement;
 
            XmlElement survivalTime = doc.CreateElement("SurvivalTime");
 
            //Values to the nodes
            survivalTime.InnerText = text.text;
 
 
            //Document Construction
            doc.AppendChild(root);
 
            // Append root element to word element
            root.AppendChild(survivalTime);
 
            //Append written values to word as child element
 
            //Save the document
            doc.Save(Path);
        }
    }
}
