using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    //Strings for updating
    public int eventID;
    public string titleString;
    public string descriptorString;
    public string result1String;
    public string result2String;
    public string result3String;
    public string result4String;
    public string buttonOneString;
    public string buttonTwoString;
    public string buttonThreeString;
    public string buttonFourString;

    //Objects to grab
    public TextMeshProUGUI title;
    public TextMeshProUGUI descriptor;
    public TextMeshProUGUI resultTitle;
    public TextMeshProUGUI results;
    public Button ButtonOne;
    public Button ButtonTwo;
    public Button ButtonThree;
    public Button ButtonFour;
    public GameObject eventCanvas;
    public GameObject managerCanvas;
    GameManager Manager;
    EventConstructor Construct;

    //Event Stipulations
    public int b1dinoValueDiff;
    public int b1dinoValueRequirement;
    public int b1guestValueDiff;
    public int b1guestValueRequirement;
    public int b1securityValueDiff;
    public int b1securityValueRequirement;
    public int b1moneyDiff;

    public int b2dinoValueDiff;
    public int b2dinoValueRequirement;
    public int b2guestValueDiff;
    public int b2guestValueRequirement;
    public int b2securityValueDiff;
    public int b2securityValueRequirement;
    public int b2moneyDiff;

    public int b3dinoValueDiff;
    public int b3dinoValueRequirement;
    public int b3guestValueDiff;
    public int b3guestValueRequirement;
    public int b3securityValueDiff;
    public int b3securityValueRequirement;
    public int b3moneyDiff;

    public int b4dinoValueDiff;
    public int b4dinoValueRequirement;
    public int b4guestValueDiff;
    public int b4guestValueRequirement;
    public int b4securityValueDiff;
    public int b4securityValueRequirement;
    public int b4moneyDiff;

    //Misc
    int eventsHappened = 0;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        eventCanvas.gameObject.SetActive(false);
        ButtonTwo.gameObject.SetActive(false);
        ButtonThree.gameObject.SetActive(false);
        ButtonFour.gameObject.SetActive(false);
        eventsHappened = 0;
        Manager = GetComponent<GameManager>();
        Construct = GetComponent<EventConstructor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (!eventCanvas.gameObject.activeSelf)
            {
                eventCanvas.gameObject.SetActive(true);
                UpdatePanel();
            }
            else
            {
                eventCanvas.gameObject.SetActive(false);
                UpdatePanel();
            }
            
        }

    }
    private void FixedUpdate()
    {
        if (timer >= 3)
        {
            managerCanvas.gameObject.SetActive(false);
        }
        else
        {
            //Debug.Log(timer);
            timer += Time.deltaTime;
        }
    }
    void UpdatePanel()
    {
        Construct.GetEvent();
        title.text = titleString;
        descriptor.text = descriptorString;
        ButtonOne.GetComponentInChildren<TextMeshProUGUI>().text = buttonOneString;
        ButtonTwo.GetComponentInChildren<TextMeshProUGUI>().text = buttonTwoString;
        ButtonThree.GetComponentInChildren<TextMeshProUGUI>().text = buttonThreeString;
        ButtonFour.GetComponentInChildren<TextMeshProUGUI>().text = buttonFourString;
        ButtonTwo.gameObject.SetActive(false);
        ButtonThree.gameObject.SetActive(false);
        ButtonFour.gameObject.SetActive(false);
        Debug.Log(Manager.secvalue + "/" + b2securityValueDiff);
        Debug.Log(Manager.secvalue + "/" + b3securityValueDiff);
        Debug.Log(Manager.secvalue + "/" + b4securityValueDiff);
        if (Manager.dinovalue < b1dinoValueRequirement || Manager.guestvalue < b1dinoValueRequirement || Manager.secvalue < b1securityValueRequirement)
        {
            ButtonOne.interactable = false;
        }
        else
        {
            ButtonOne.interactable = true;
        }
        if (buttonTwoString != "")
        {
            ButtonTwo.gameObject.SetActive(true);
            if (Manager.dinovalue < b2dinoValueRequirement || Manager.guestvalue < b2dinoValueRequirement || Manager.secvalue < b2securityValueRequirement)
            {
                ButtonTwo.interactable = false;
            }
            else
            {
                ButtonTwo.interactable = true;
            }
        }
        if (buttonThreeString != "")
        {
            ButtonThree.gameObject.SetActive(true);
            if (Manager.dinovalue < b3dinoValueRequirement || Manager.guestvalue < b3dinoValueRequirement || Manager.secvalue < b3securityValueRequirement)
            {
                ButtonThree.interactable = false;
            }
            else
            {
                ButtonThree.interactable = true;
            }
        }
        if (buttonFourString != "")
        {
            ButtonFour.gameObject.SetActive(true);
            if (Manager.dinovalue < b4dinoValueRequirement || Manager.guestvalue < b4dinoValueRequirement || Manager.secvalue < b4securityValueRequirement)
            {
                ButtonFour.interactable = false;
            }
            else
            {
                ButtonFour.interactable = true;
            }
        }
    }

    public void ResolvePanel(int input)
    {
        timer = 0;
        eventCanvas.gameObject.SetActive(false);
        managerCanvas.gameObject.SetActive(true);
        eventsHappened += 1;
        if (input == 1)
        {
            resultTitle.text = buttonOneString;
            results.text = result1String;
            GetComponent<GameManager>().dinovalue += b1dinoValueDiff;
            GetComponent<GameManager>().guestvalue += b1guestValueDiff;
            GetComponent<GameManager>().secvalue += b1securityValueDiff;
            GetComponent<GameManager>().money += b1moneyDiff;
        }
        else if (input == 2)
        {
            resultTitle.text = buttonOneString;
            results.text = result2String;

            GetComponent<GameManager>().dinovalue += b2dinoValueDiff;
            GetComponent<GameManager>().guestvalue += b2guestValueDiff;
            GetComponent<GameManager>().secvalue += b2securityValueDiff;
            GetComponent<GameManager>().money += b2moneyDiff;
        }
        else if (input == 3)
        {
            resultTitle.text = buttonOneString;
            results.text = result3String;
            GetComponent<GameManager>().dinovalue += b3dinoValueDiff;
            GetComponent<GameManager>().guestvalue += b3guestValueDiff;
            GetComponent<GameManager>().secvalue += b3securityValueDiff;
            GetComponent<GameManager>().money += b3moneyDiff;
        }
        else if (input == 4)
        {
            resultTitle.text = buttonOneString;
            results.text = result4String;
            GetComponent<GameManager>().dinovalue += b4dinoValueDiff;
            GetComponent<GameManager>().guestvalue += b4guestValueDiff;
            GetComponent<GameManager>().secvalue += b4securityValueDiff;
            GetComponent<GameManager>().money += b4moneyDiff;
        }
        if (eventsHappened == 3)
        {
            GameManager money = GetComponent<GameManager>();
            money.money += money.dinovalue * money.guestvalue * money.secvalue * 500;
            eventsHappened = 0;
            Manager.UpdateMoney();
        }
        Manager.CheckForFailure();
    }
}
