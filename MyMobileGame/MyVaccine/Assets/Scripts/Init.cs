using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Memory memory = GetComponent<Memory>();
        memory.LoadPlayer();
        
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
