using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmusic : MonoBehaviour
{
    AudioSource music;
    float vol;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        vol = PlayerPrefs.GetFloat("VOL", 1);
        music.volume = vol;
    }

    public void musicplay()
    {
        music.Play();
    }
}
