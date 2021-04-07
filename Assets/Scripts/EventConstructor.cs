using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class EventConstructor : MonoBehaviour
{
    SaveData SD;
    public List<GameObject> objectlist;
    int currentEvent;
    public GameObject empty;
    EventManager manager;
    void Start()
    {
        manager = gameObject.GetComponent<EventManager>();
        Debug.Log("Load Data"); 
        SD = new SaveData();
        XmlSerializer x = new XmlSerializer(typeof(SaveData));
        FileStream file = new FileStream("eventlist.xml", FileMode.Open);
        SD = (SaveData)x.Deserialize(file);
        file.Close();

        Debug.Log("DataSize: " + SD.DataSize()); 
        
        /*foreach (EventData data in SD.EventList)
        {
            Debug.Log("Data Item");
            GameObject gObj = Instantiate(empty, new Vector3(0, -500, 0), Quaternion.identity);
            EventContent content = gObj.GetComponent<EventContent>();


                content.eventID = data.eventID;
                content.dinoValueDiff = data.dinoValueDiff;
                content.dinoValueRequirement = data.dinoValueRequirement;
                content.guestValueDiff = data.guestValueDiff;
                content.guestValueRequirement = data.guestValueRequirement;
                content.securityValueDiff = data.securityValueDiff;
                content.securityValueRequirement = data.securityValueRequirement;
                content.moneyDiff = data.moneyDiff;
                content.titleString = data.titleString;
                content.descriptorString = data.descriptorString;
                content.result1String = data.result1String;
                content.buttonOneString = data.buttonOneString;
                content.result2String = data.result2String;
                content.buttonTwoString = data.buttonTwoString;
                content.result3String = data.result3String;
                content.buttonThreeString = data.buttonThreeString;
                content.result4String = data.result4String;
                content.buttonFourString = data.buttonFourString;


                objectlist.Add(gObj);
        }
        */
    }

    public void GetEvent()
    {
        currentEvent = Random.Range(0, SD.DataSize());
        manager.eventID = SD.EventList[currentEvent].eventID;
        manager.b1dinoValueDiff = SD.EventList[currentEvent].b1dinoValueDiff;
        manager.b1dinoValueRequirement = SD.EventList[currentEvent].b1dinoValueRequirement;
        manager.b1guestValueDiff = SD.EventList[currentEvent].b1guestValueDiff;
        manager.b1guestValueRequirement = SD.EventList[currentEvent].b1guestValueRequirement;
        manager.b1securityValueDiff = SD.EventList[currentEvent].b1securityValueDiff;
        manager.b1securityValueRequirement = SD.EventList[currentEvent].b1securityValueRequirement;
        manager.b1moneyDiff = SD.EventList[currentEvent].b1moneyDiff;

        manager.b2dinoValueDiff = SD.EventList[currentEvent].b2dinoValueDiff;
        manager.b2dinoValueRequirement = SD.EventList[currentEvent].b2dinoValueRequirement;
        manager.b2guestValueDiff = SD.EventList[currentEvent].b2guestValueDiff;
        manager.b2guestValueRequirement = SD.EventList[currentEvent].b2guestValueRequirement;
        manager.b2securityValueDiff = SD.EventList[currentEvent].b2securityValueDiff;
        manager.b2securityValueRequirement = SD.EventList[currentEvent].b2securityValueRequirement;
        manager.b2moneyDiff = SD.EventList[currentEvent].b2moneyDiff;

        manager.b3dinoValueDiff = SD.EventList[currentEvent].b3dinoValueDiff;
        manager.b3dinoValueRequirement = SD.EventList[currentEvent].b3dinoValueRequirement;
        manager.b3guestValueDiff = SD.EventList[currentEvent].b3guestValueDiff;
        manager.b3guestValueRequirement = SD.EventList[currentEvent].b3guestValueRequirement;
        manager.b3securityValueDiff = SD.EventList[currentEvent].b3securityValueDiff;
        manager.b3securityValueRequirement = SD.EventList[currentEvent].b3securityValueRequirement;
        manager.b3moneyDiff = SD.EventList[currentEvent].b3moneyDiff;

        manager.b4dinoValueDiff = SD.EventList[currentEvent].b4dinoValueDiff;
        manager.b4dinoValueRequirement = SD.EventList[currentEvent].b4dinoValueRequirement;
        manager.b4guestValueDiff = SD.EventList[currentEvent].b4guestValueDiff;
        manager.b4guestValueRequirement = SD.EventList[currentEvent].b4guestValueRequirement;
        manager.b4securityValueDiff = SD.EventList[currentEvent].b4securityValueDiff;
        manager.b4securityValueRequirement = SD.EventList[currentEvent].b4securityValueRequirement;
        manager.b4moneyDiff = SD.EventList[currentEvent].b4moneyDiff;

        manager.titleString = SD.EventList[currentEvent].titleString;
        manager.descriptorString = SD.EventList[currentEvent].descriptorString;
        manager.result1String = SD.EventList[currentEvent].result1String;
        manager.buttonOneString = SD.EventList[currentEvent].buttonOneString;
        manager.result2String = SD.EventList[currentEvent].result2String;
        manager.buttonTwoString = SD.EventList[currentEvent].buttonTwoString;
        manager.result3String = SD.EventList[currentEvent].result3String;
        manager.buttonThreeString = SD.EventList[currentEvent].buttonThreeString;
        manager.result4String = SD.EventList[currentEvent].result4String;
        manager.buttonFourString = SD.EventList[currentEvent].buttonFourString;
    }

}
