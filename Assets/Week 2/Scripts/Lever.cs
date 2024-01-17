using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeInHierarchy == true)
        {
            door.SetActive(false);
            Debug.Log("f");
        }
        else (door.activeInHierarchy == false)
        {
            door.SetActive(true);
            Debug.Log("t");
        }
    }
}