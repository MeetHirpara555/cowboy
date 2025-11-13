using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biirdgen : MonoBehaviour
{
    public GameObject bird;
    int mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("mode");
        if(mode == 0)
        {
            InvokeRepeating("birdgen", 2f, 4f);
        }

        if (mode == 1)
        {
            InvokeRepeating("birdgen", 2f, 1.5f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void birdgen()
    {
        float i = Random.Range(1f, 4f);
        transform.position = new Vector2(transform.position.x, i);
        GameObject bir = Instantiate(bird, transform.position, Quaternion.identity);
        Destroy(bir, 9f);
    }
}
