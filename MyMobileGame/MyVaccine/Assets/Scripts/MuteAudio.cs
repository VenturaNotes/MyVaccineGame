using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public AudioSource music;

    public void Silence()
    {
        music.volume = 0;
    }

}
