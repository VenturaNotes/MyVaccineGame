using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cytokine;
    public Camera cam;
    public AudioSource shoot;
    private int max;
    private int count;
    private bool pause;

    private Vector3 mouse;

    void Start()
    {
        shoot = GetComponent<AudioSource>();
        max = 20;
        count = max;
    }

    public float lastPressed()
    {
        return (mouse.y - transform.position.y) / (mouse.x - transform.position.x);
    }

    public float xDistance()
    {
        return (mouse.x - transform.position.x);
    }

    private bool Upgrade1()
    {
        return false;
    }

    // Update is called once per frame
   void Update()
    {
        if(cam.ScreenToWorldPoint(Input.mousePosition).y <= 4.0 && GameObject.Find("PauseScreen").GetComponent<Pause>().paused == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mouse = cam.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(mouse);
                count = 0;
                Instantiate(cytokine, transform.position, Quaternion.identity);
            }
            else if (Input.GetMouseButton(0) && count == max)
            {
                mouse = cam.ScreenToWorldPoint(Input.mousePosition);
                count = 0;
                Instantiate(cytokine, transform.position, Quaternion.identity);
            }

            if (count < max)
            {
                count += 1;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Virus"))
        {
            //Changes Color
            //GetComponent<SpriteRenderer>().color = new Color(1f, 0.30196078f, 0.30196078f);
            
            //Destroy(other.gameObject);
        }
    }
}
