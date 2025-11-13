using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    
    public Text totalCoins,highscore;
    int tc;
    float hs;
    // Start is called before the first frame update
    void Start()
    {
        

        tc = PlayerPrefs.GetInt("TC", 0);
        totalCoins.text = "" + tc;

        hs = PlayerPrefs.GetFloat("HS", 0f);
        highscore.text = "" + (int)hs;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playbtn()
    {
        SceneManager.LoadScene("levels");
    }

    public void settingbtn()
    {
        SceneManager.LoadScene("settings");
    }
}
