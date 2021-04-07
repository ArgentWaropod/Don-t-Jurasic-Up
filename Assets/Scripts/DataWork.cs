using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class DataWork : MonoBehaviour
{
    SaveData SD; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.J))
        {
            MakeSave();
        }
        */
    }

    void MakeSave()
    {
        Debug.Log("Make Save = Start");
        MakeDefaultData();
        string filename = "eventlist.xml";

        XmlSerializer x = new XmlSerializer(typeof(SaveData));
        TextWriter writer = new StreamWriter(filename);
        x.Serialize(writer, SD);
        writer.Close();
        Debug.Log("Make Save = End");
    }

    void MakeDefaultData()
    {
        SD = new SaveData();
        Debug.Log("Make Save object");
        SD.AddItem(001, 11, 12, 13, 14, 15, 16, "title1", "desc1", "ra1", "rb1", "rc1", "rd1", "ba1", "bb1", "bc1", "bd1", 9001, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Debug.Log("Make object 1");
        SD.AddItem(002, 21, 22, 23, 24, 25, 26, "title2", "desc2", "ra2", "rb2", "rc2", "rd2", "ba2", "bb2", "bc2", "bd2", 9002, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        Debug.Log("Make object 1");
    }
}
