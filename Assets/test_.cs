using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_ : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction);
    }
}
