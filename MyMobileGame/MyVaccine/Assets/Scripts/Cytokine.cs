using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cytokine : MonoBehaviour
{
    private float xDistance;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan(GameObject.Find("TCell").GetComponent<Player>().lastPressed()));
        xDistance = GameObject.Find("TCell").GetComponent<Player>().xDistance();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (xDistance > 0)
        {
            transform.position += transform.right * .1f;
        }
        else
        {
            transform.position += -transform.right * .1f;
        }

        if (transform.position.x > 4 || transform.position.x <-4 || transform.position.y > 3.987 || transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Virus"))
        {
            GameObject.Find("TCell").GetComponent<Player>().shoot.Play();
            GameObject.Find("Initialize").GetComponent<Memory>().researchPoints += 1; 
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
