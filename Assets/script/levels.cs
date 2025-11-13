using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backbtn()
    {
        SceneManager.LoadScene("home");
    }

    public void easybtn()
    {
        SceneManager.LoadScene("play");
        PlayerPrefs.SetInt("mode", 0);

    }

    public void hardbtn()
    {
        SceneManager.LoadScene("play");
        PlayerPrefs.SetInt("mode", 1);
    }
}
