using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int researchPoints;

    public PlayerData (Memory player)
    {
        researchPoints = player.researchPoints;
    }
}
