using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Virus1;
    public GameObject Virus2;
    public GameObject Virus3;
    bool start;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
        count = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (start)
        {
            if (count == 60)
            {
                Instantiate(Virus1, new Vector3(Random.Range(-2.3f, 2.3f), 7f, 0f), Quaternion.identity);
                count = 0;
            }
            count += 1;
        }
    }
}
