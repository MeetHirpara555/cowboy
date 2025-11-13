using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    float Tt,hs;
    public Text score;
    int co,tc;
    // Start is called before the first frame update
    void Start()
    {
        Tt = PlayerPrefs.GetFloat("TT");
        hs = PlayerPrefs.GetFloat("HS");
        if(Tt > hs)
        {
            PlayerPrefs.SetFloat("HS",Tt);
        }
        score.text = ""+(int) Tt;

        co = PlayerPrefs.GetInt("CC");

        tc = PlayerPrefs.GetInt("TC");
        tc += co;
        PlayerPrefs.SetInt("TC", tc);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void replaybtn()
    {
        SceneManager.LoadScene("play");
    }

    public void homebtn()
    {
        SceneManager.LoadScene("home");
    }
}
