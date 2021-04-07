using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 


    public double money = 1000.00;
    public int dinovalue = 5;
    public int maxdino = 10;
    public int guestvalue = 5;
    public int maxguest = 10;
    public int secvalue = 5;
    public int maxsec = 10;
    public double currentPrice = 0;
    public Slider dinoSlider;
    public Slider guestSlider;
    public Slider securitySlider;
    public TextMeshProUGUI UImoney;
    public GameObject areUSure;
    public TextMeshProUGUI USureField;
    LandClear landtoclear;
    int bankrupt = 0;


    void Awake()
    {
        instance = this; 
    }

    void Start()
    {
        dinoSlider.maxValue = maxdino;
        guestSlider.maxValue = maxguest;
        securitySlider.maxValue = maxsec;
        UpdateMoney();
        GetCardData(); 
    }


    void GetCardData()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoney();
        Debug.Log("Updating bars");
        dinoSlider.value = dinovalue;
        if (dinovalue > maxdino)
        {
            dinovalue = maxdino;
        }
        guestSlider.value = guestvalue;
        if (guestvalue > maxguest)
        {
            guestvalue = maxguest;
        }
        securitySlider.value = guestvalue;
        if (secvalue > maxsec)
        {
            secvalue = maxsec;
        }
        dinoSlider.maxValue = maxdino;
        guestSlider.maxValue = maxguest;
        securitySlider.maxValue = maxsec;
        if (Input.GetMouseButtonDown(0))
        {
            Ray clicker = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(clicker, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.transform.tag.Equals("BuySpace"))
                {
                    landtoclear = hit.collider.gameObject.GetComponent<LandClear>();
                    currentPrice = landtoclear.costToClear;
                    areUSure.gameObject.SetActive(true);
                    Debug.Log(currentPrice.ToString());
                    USureField.text = "Are you sure you want to buy this for $" + currentPrice.ToString() + "?";
                }
            }
        }

    }
    
    public void UpdateMoney()
    {
        UImoney.text = "$" + money.ToString();
        if (money > 0.00)
        {
            UImoney.color = new Color(0, 255, 0, 100);
        }
        else
        {
            UImoney.color = new Color(255, 0, 0, 100);
        }
    }
    public void MenuYes()
    {
        areUSure.gameObject.SetActive(false);
        money = money - currentPrice;
        landtoclear.ClearLand();
        UpdateMoney();
    }
    public void MenuNo()
    {
        areUSure.gameObject.SetActive(false);
    }
    public void CheckForFailure()
    {
        if (money < 0)
        {
            bankrupt += 1;
        }
        if (bankrupt == 3 || dinovalue < 0 || guestvalue < 0 || secvalue < 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
