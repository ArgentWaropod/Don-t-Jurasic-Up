using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public Animator animator;
    public string[] result;
    public string[] ceos;
    public string[] promises;
    public TextMeshProUGUI headline;
    public TextMeshProUGUI statement;
    public GameObject escapeMenu;
    float timer;
    bool exiting;
    // Start is called before the first frame update
    void Start()
    {
        exiting = false;
        escapeMenu.SetActive(false);
        headline.text = result[Random.Range(0, result.Length)];
        statement.text = "New CEO " + ceos[Random.Range(0, ceos.Length)] + " " + promises[Random.Range(0, promises.Length)];
    }
    void Update()
    {
        if (timer >= 5)
        {
            escapeMenu.SetActive(true);
        }
        else if (timer >= 1 && exiting == true)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void Return()
    {
        animator.SetTrigger("FadeOut");
        escapeMenu.SetActive(false);
        exiting = true;
        timer = 0;
    }
}
