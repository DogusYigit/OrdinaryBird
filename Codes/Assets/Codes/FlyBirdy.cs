using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBirdy : MonoBehaviour
{
    public GameManager GameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource JumpSoundEffect;
    [SerializeField] private AudioSource GameOverSoundEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            JumpSoundEffect.Play();
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
        GameOverSoundEffect.Play();
    }
}
