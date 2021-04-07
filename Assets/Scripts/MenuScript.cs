using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public float speed;
    public GameObject buttons;
    public GameObject credits;
    bool incredits = false;

    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(false);
        credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.localPosition.y);
        if (transform.localPosition.y > 12)
        {
            transform.Translate(0, -speed, 0);
        }
        else if (incredits != true)
        {
            buttons.SetActive(true);
        }
    }

    public void exit()
    {
        Application.Quit();
    }
    public void advance()
    {
        SceneManager.LoadScene(1);
    }
    public void theCredits()
    {
        buttons.SetActive(false);
        credits.SetActive(true);
        incredits = true;
    }
    public void returnFromCredits()
    {
        credits.SetActive(false);
        buttons.SetActive(true);
        incredits = false;
    }
}
