using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    MeshRenderer model;
    Rigidbody rb;
    public float dinoSpeed;
    bool isTraveling;
    float moveBackDistance;
    float rotate;
    public GameManager manager;
    public int dinoscore;
    // Start is called before the first frame update
    void Start()
    {
        model = gameObject.GetComponentInChildren<MeshRenderer>();
        isTraveling = true;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.dinovalue > dinoscore)
        {
            model.enabled = true;
            if (isTraveling == true)
            {
                Debug.Log("Traveling");
                rb.velocity = dinoSpeed * transform.forward;
            }
            else
            {
                if (rb.position.z >= moveBackDistance)
                {
                    Debug.Log("Moving Back");
                    rb.velocity = dinoSpeed * transform.forward * -1;

                }
                else if (rb.rotation.y * 100 >= rotate + 10 || rb.rotation.y * 100 <= rotate - 10)
                {
                        gameObject.transform.Rotate(gameObject.transform.up, 1, Space.World);
                }
                else
                {
                    isTraveling = true;
                    Debug.Log("Traveling Again");
                }
            }
        }
        else
        {
            model.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isTraveling = false;
        moveBackDistance = rb.position.z - 15;
        rotate = Random.Range(-90, 90);
        Debug.Log(rotate.ToString());
        rb.velocity = dinoSpeed * transform.forward * -3;
    }
}
