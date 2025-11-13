using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletgen : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            GameObject bull = Instantiate(bullet,transform.position,Quaternion.identity);
            Destroy(bull,3f);
        }
    }
}
