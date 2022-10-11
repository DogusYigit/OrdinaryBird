using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] private AudioSource enterSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enterSoundEffect.Play();
        Score.score++;
    }
}
