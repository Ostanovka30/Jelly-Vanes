using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //персонаж движется ("падает") под действием гравитации по оси Y

    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
    public Platform CurrentPlatform;
    public Vector3 collisionPoint;
    public Vector3 oldCollisionPoint;
    private AudioSource _audio;
    public AudioClip AudioDeath;
    public AudioClip AudioFinish;


    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }



    public void ReachFinish()
    {
        Game.OnPlayerReachFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        AudioPlay();
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
        _audio.PlayOneShot(AudioDeath);

    }


    private void AudioPlay()
    {
        _audio.Play();
    }


    public void FinishSound()
    {
        _audio.PlayOneShot(AudioFinish);
    }
}
