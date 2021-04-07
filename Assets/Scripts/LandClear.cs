using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandClear : MonoBehaviour
{
    public GameObject landtoclear;
    public GameObject newland;
    public GameManager manager;
    public int costToClear;
    private void Start()
    {
        landtoclear.gameObject.SetActive(true);
        newland.gameObject.SetActive(false);
    }
    public void ClearLand()
    {
        landtoclear.gameObject.SetActive(false);
        newland.gameObject.SetActive(true);
        Destroy(gameObject);
        manager.maxdino += 2;
        manager.maxguest += 2;
        manager.maxsec += 2;
    }
}
