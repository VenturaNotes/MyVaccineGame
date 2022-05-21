using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus1 : MonoBehaviour
{
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.transform.position = new Vector3(rb2d.transform.position.x, rb2d.transform.position.y - 0.06f,6);
        if (transform.position.y <= -9)
        {
            Destroy(gameObject);
        }
    }
}
