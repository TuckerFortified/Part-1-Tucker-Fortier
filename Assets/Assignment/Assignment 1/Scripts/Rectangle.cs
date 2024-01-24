using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    public GameObject floatingObject;
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(floatingObject, spawnPoint.position, spawnPoint.rotation);
    }

}
