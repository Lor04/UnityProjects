using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JepMusic : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioSource MusicSource; //reference to our audiosource

    public void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) // If N is hit music will play
            MusicSource.Play();
        if (Input.GetKeyDown(KeyCode.M)) // If M is hit music will play
            MusicSource.Stop();
    }
}
