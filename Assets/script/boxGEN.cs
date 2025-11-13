using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxGEN : MonoBehaviour
{
    public GameObject[] box;
    public GameObject genpoint;
    int mode;
    float i;

    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("mode");

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < genpoint.transform.position.x)
        {
            if(mode == 0)
            {
                i = Random.Range(15f, 30f);
            }

            if (mode == 1)
            {
                 i = Random.Range(15f, 23f);
            }
            

            
            int j = Random.Range(0, 4);
            transform.position = new Vector2(transform.position.x + i, transform.position.y);
            GameObject bg = Instantiate(box[j],transform.position,Quaternion.identity);
            Destroy(bg, 12f);
        }
    }

    
}
