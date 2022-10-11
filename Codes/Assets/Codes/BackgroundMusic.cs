using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioSource BackGroundMusic;
    public static bool isGameMuted = false;
    public void OnbackGroundMusic()
    {
        isGameMuted = false;
        BackGroundMusic.Play();
    }

    public void OffbackGroundMusic()
    {
        isGameMuted = true;
        BackGroundMusic.Stop();   
    }

}
