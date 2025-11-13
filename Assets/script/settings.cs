using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public Text sound;
    public Slider slider;
    float vol,last;
    // Start is called before the first frame update
    void Start()
    {
        
        vol = PlayerPrefs.GetFloat("VOL",slider.value);
        slider.value = vol;
        
        if(vol > 0 )
        {
            sound.text = "SOUND ON";
        }
        if (vol == 0)
        {
            sound.text = "SOUND OFF";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onoffbtn()
    {
        string temp = sound.text;
        if(temp == "SOUND ON")
        {
            last = slider.value;
            PlayerPrefs.SetFloat("VOL",0f);
            vol = PlayerPrefs.GetFloat("VOL");
            sound.text = "SOUND OFF";
            slider.value = vol;
            
        }

        if(temp == "SOUND OFF")
        {
            PlayerPrefs.SetFloat("VOL", last);
            vol = PlayerPrefs.GetFloat("VOL");
            sound.text = "SOUND ON";
            slider.value = vol;
            
        }
    }

    public void sliderbtn()
    {
        PlayerPrefs.SetFloat("VOL", slider.value);
        if(slider.value > 0f)
        {
            sound.text = "SOUND ON";
        }
        if(slider.value == 0f)
        {
            sound.text = "SOUND OFF";
        }
    }

    public void backbtn()
    {
        SceneManager.LoadScene("home");
    }
}

