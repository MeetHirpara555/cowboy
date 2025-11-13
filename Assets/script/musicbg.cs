using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicbg : MonoBehaviour
{
    AudioSource music;
    float vol;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        music = GetComponent<AudioSource>();
        
        music.Play();

    }

    // Update is called once per frame
    void Update()
    {
        vol = PlayerPrefs.GetFloat("VOL",1f);
        music.volume = vol;
    }
}
