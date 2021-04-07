using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoEnable : MonoBehaviour
{
    public GameManager manager;
    GameObject child;
    public int dinoreq;
    // Start is called before the first frame update
    void Start()
    {
        child = gameObject.transform.GetChild(0).transform.GetComponent<GameObject>();
        child.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        child = gameObject.transform.GetChild(0).transform.GetComponent<GameObject>();
        if (manager.dinovalue >= dinoreq)
        {
            child.SetActive(true);
        }
    }
}
