using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpver : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform spawn;
    float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(missilePrefab, spawn.position, spawn.rotation);
        }

    }
}
