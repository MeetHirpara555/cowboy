
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingen : MonoBehaviour
{
    public GameObject coinn,genpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genpoint.transform.position.x)
        {
            float i = Random.Range(10f, 15f);
            transform.position = new Vector2(transform.position.x + i, transform.position.y);
            GameObject co = Instantiate(coinn, transform.position, Quaternion.identity);
            Destroy(co, 9f);
        }
       
    }

}
