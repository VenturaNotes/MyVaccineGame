using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    public int researchPoints = 0;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        if(data == null)
        {
            //Should tell user file not found, would they like to create a new one?
            SaveSystem.SavePlayer(this);
        }
        else
        {
            researchPoints = data.researchPoints;
        }
    }

    public void ResetPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        researchPoints = 0;

        SaveSystem.SavePlayer(this);
    }
}
