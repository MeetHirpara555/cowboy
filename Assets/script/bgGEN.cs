using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgGEN : MonoBehaviour
{
    public GameObject bg,genpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < genpoint.transform.position.x)
        {
            print("hello");
            transform.position = new Vector2(transform.position.x + 20f, transform.position.y);
            GameObject bgg = Instantiate(bg, transform.position, Quaternion.identity);
            Destroy(bgg,12f);
        }
    }
}
